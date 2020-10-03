using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.DTO;
using DesafioLanche.WebApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DesafioLanche.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private static ILancheBusiness _lancheBusiness;
        private static IPromocaoBusiness _promocaoBusiness;
        private static IMapper _mapper;

        public HomeController(ILancheBusiness lancheBusiness, IPromocaoBusiness promocaoBusiness, IMapper mapper)
        {
            _lancheBusiness = lancheBusiness;
            _promocaoBusiness = promocaoBusiness;
            _mapper = mapper;
        }


        /// <summary>
        /// Action Index onde será carregada a lista de lanches com seus ingredientes.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> Index()
        {
            var lanches = await _lancheBusiness.SelectLancheByStatusAsync(LancheStatusDTO.ATIVO, true);

            var lanchesViewModel = _mapper.Map<List<LancheViewModel>>(lanches);          

            return View(lanchesViewModel);
        }

        public async Task<PartialViewResult> Promocao()
        {
            var promocoes = await _promocaoBusiness.SelectPromocaoByStatusAsync(PromocaoStatusDTO.ATIVO, true);

            var promocoesViewModel = _mapper.Map<List<PromocaoViewModel>>(promocoes);

            return PartialView("~/Views/Home/_PromocaoPartialView.cshtml", promocoesViewModel);
        }



        /*
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        */
    }
}