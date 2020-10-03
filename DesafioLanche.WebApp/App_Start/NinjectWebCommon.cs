[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(DesafioLanche.WebApp.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(DesafioLanche.WebApp.App_Start.NinjectWebCommon), "Stop")]

namespace DesafioLanche.WebApp.App_Start
{
    using AutoMapper;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using System;
    using System.Web;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            /*
             * Em qualquer parte da aplicação que houver um construtor que 
             * solicite por uma instância da classe ApplicationDbContext, 
             * o Ninject se encarregará de todo o processo.
             * 
             * Da mesma forma, quando um construtor pedir por uma instância de uma
             * classe que implemente a interface IAlgumaCoisaRepository ou IAlgumaCoisaBusiness, 
             * o Ninject automaticamente criará uma instância da classe AlgumaCoisaRepository ou AlgumaCoisaBusiness 
             * e passará como parâmetro.
             * 
             *  O método InRequestScope() diz que uma instância das referidas classes
             *  será criada para cada requisição feita, normalmente é a opção que oferece a melhor performance.
             *  
             *  Mais info em  https://github.com/ninject/ninject/wiki
             * 
             */


            // Ajuda para ajustar o Automapper com varios profiles no projeto MVC:
            // https://stackoverflow.com/questions/43560555/how-do-i-use-ninject-to-inject-automapper-mapper-in-place-of-imapper
            kernel.Bind<IMapper>().ToMethod(context =>
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile<DesafioLanche.Business.Helper.AutoMapperProfiles>();
                        cfg.AddProfile<DesafioLanche.WebApp.Helper.AutoMapperProfiles>();
                        // tell automapper to use ninject when creating value converters and resolvers
                        cfg.ConstructServicesUsing(t => kernel.Get(t));
                    });
                    return config.CreateMapper();
                }).InSingletonScope();


            kernel.Bind<Repository.Context.DesafioLancheContext>().ToSelf().InRequestScope();     // recomendado para aplicações no IIS.
        
            kernel.Bind<Repository.Interfaces.IClienteRepository>().To<Repository.Classes.ClienteRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.IClienteBusiness>().To<Business.Classes.ClienteBusiness>().InRequestScope();

            kernel.Bind<Repository.Interfaces.IEnderecoRepository>().To<Repository.Classes.EnderecoRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.IEnderecoBusiness>().To<Business.Classes.EnderecoBusiness>().InRequestScope();

            kernel.Bind<Repository.Interfaces.IIngredienteRepository>().To<Repository.Classes.IngredienteRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.IIngredienteBusiness>().To<Business.Classes.IngredienteBusiness>().InRequestScope();

            kernel.Bind<Repository.Interfaces.ILancheRepository>().To<Repository.Classes.LancheRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.ILancheBusiness>().To<Business.Classes.LancheBusiness>().InRequestScope();

            kernel.Bind<Repository.Interfaces.ILancheXingredienteRepository>().To<Repository.Classes.LancheXingredienteRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.ILancheXingredienteBusiness>().To<Business.Classes.LancheXingredienteBusiness>().InRequestScope();

            kernel.Bind<Repository.Interfaces.IPedidoRepository>().To<Repository.Classes.PedidoRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.IPedidoBusiness>().To<Business.Classes.PedidoBusiness>().InRequestScope();

            kernel.Bind<Repository.Interfaces.IPedidoXlancheXingredienteRepository>().To<Repository.Classes.PedidoXlancheXingredienteRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.IPedidoXlancheXingredienteBusiness>().To<Business.Classes.PedidoXlancheXingredienteBusiness>().InRequestScope();

            kernel.Bind<Repository.Interfaces.IPromocaoRepository>().To<Repository.Classes.PromocaoRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.IPromocaoBusiness>().To<Business.Classes.PromocaoBusiness>().InRequestScope();

            kernel.Bind<Repository.Interfaces.IPromocaoXingredienteRepository>().To<Repository.Classes.PromocaoXingredienteRepository>().InRequestScope();
            kernel.Bind<Business.Interfaces.IPromocaoXingredienteBusiness>().To<Business.Classes.PromocaoXingredienteBusiness>().InRequestScope();


        }
    }
}