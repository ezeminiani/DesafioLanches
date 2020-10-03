namespace DesafioLanche.Repository.Migrations
{
    using DesafioLanche.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;

    internal sealed class Configuration : DbMigrationsConfiguration<DesafioLanche.Repository.Context.DesafioLancheContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DesafioLanche.Repository.Context.DesafioLancheContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            try
            {
                // Adicionando os ingredientes default.

                var ingredientes = new List<Ingrediente>
                {
                    new Ingrediente { Id = 1, Nome = "Alface", Descricao = "Alface fresca", Preco = .40M, Status = IngredienteStatus.ATIVO },
                    new Ingrediente { Id = 2, Nome = "Bacon", Descricao = "Bacon", Preco = 2.0M, Status = IngredienteStatus.ATIVO },
                    new Ingrediente { Id = 3, Nome = "Hamburger de Carne", Descricao = "Hamburger de Carne", Preco = 3.0M, Status = IngredienteStatus.ATIVO },
                    new Ingrediente { Id = 4, Nome = "Ovo", Descricao = "Ovo", Preco = .80M, Status = IngredienteStatus.ATIVO },
                    new Ingrediente { Id = 5, Nome = "Queijo", Descricao = "Queijo", Preco = 1.50M, Status = IngredienteStatus.ATIVO }
                };

                context.Ingrediente.AddOrUpdate(ingredientes.ToArray());


                // Adicionado os lanches.
                var lanches = new List<Lanche>
                {
                    new Lanche { 
                        Id = 1, Nome = "X-Bacon", Descricao = "O melhor X-Bacon!", Status = LancheStatus.ATIVO, Fixo = true, Epromocao = false,
                        LancheXingredientes = new List<LancheXingrediente> { 
                            new LancheXingrediente { Id = 1, IngredienteId = 2, LancheId = 1 },
                            new LancheXingrediente { Id = 2, IngredienteId = 3, LancheId = 1 },
                            new LancheXingrediente { Id = 3, IngredienteId = 5, LancheId = 1 }
                        } 
                    },
                    new Lanche {
                        Id = 2, Nome = "X-Burger", Descricao = "X-Burger sem comparação!", Status = LancheStatus.ATIVO, Fixo = true, Epromocao = false,
                        LancheXingredientes = new List<LancheXingrediente> {
                            new LancheXingrediente { Id = 4, IngredienteId = 3, LancheId = 2 },
                            new LancheXingrediente { Id = 5, IngredienteId = 5, LancheId = 2 }
                        }
                    },
                    new Lanche {
                        Id = 3, Nome = "X-Egg", Descricao = "X-Egg Galinzé!", Status = LancheStatus.ATIVO, Fixo = true, Epromocao = false,
                        LancheXingredientes = new List<LancheXingrediente> {
                            new LancheXingrediente { Id = 6, IngredienteId = 4, LancheId = 3 },
                            new LancheXingrediente { Id = 7, IngredienteId = 3, LancheId = 3 },
                            new LancheXingrediente { Id = 8, IngredienteId = 5, LancheId = 3 }
                        }
                    },
                    new Lanche {
                        Id = 4, Nome = "X-Egg Bacon", Descricao = "X-Egg Super Frango!", Status = LancheStatus.ATIVO, Fixo = true, Epromocao = false,
                        LancheXingredientes = new List<LancheXingrediente> {
                            new LancheXingrediente { Id = 9, IngredienteId = 2, LancheId = 4 },
                            new LancheXingrediente { Id = 10, IngredienteId = 3, LancheId = 4 },
                            new LancheXingrediente { Id = 11, IngredienteId = 4, LancheId = 4 },
                            new LancheXingrediente { Id = 12, IngredienteId = 5, LancheId = 4 }
                        }
                    },
                    new Lanche { Id = 5, Nome = "Personalizado", Descricao = "Personalize seu lanche!", Status = LancheStatus.ATIVO, Fixo = false, Epromocao = false },

                    new Lanche { Id = 6, Nome = "Promoção", Descricao = "Aproveite nossas promoções!", Status = LancheStatus.ATIVO, Fixo = false, Epromocao = true  },
                };

                context.Lanche.AddOrUpdate(lanches.ToArray());


                // Adicionando as promoções
                var promocoes = new List<Promocao>
                {
                    new Promocao { Id = 1, Nome = "Light", LancheId = 6, Status = PromocaoStatus.ATIVO, Desconto = 10.0M, Descricao = "10% de desconto para lanches com alface mas sem bacon!", 
                        PromocaoXingredientes = new List<PromocaoXingrediente> {
                            new PromocaoXingrediente { Id = 1, PromocaoId = 1, IngredienteId = 1, Quantidade = 1, Contem = true },
                            new PromocaoXingrediente { Id = 2, PromocaoId = 1, IngredienteId = 2, Quantidade = 1, Contem = false },
                        }
                    },
                    new Promocao { Id = 2, Nome = "Muita Carne", LancheId = 6, Status = PromocaoStatus.ATIVO, Desconto = 33.0M, Descricao = "A cada 3 porções de carne o cliente só paga 2!", 
                        PromocaoXingredientes = new List<PromocaoXingrediente> {
                            new PromocaoXingrediente { Id = 3, PromocaoId = 2, IngredienteId = 3, Quantidade = 3, Contem = true }
                        }
                    },
                    new Promocao { Id = 3, Nome = "Muito Queijo", LancheId = 6, Status = PromocaoStatus.ATIVO, Desconto = 33.0M, Descricao = "A cada 3 porções de queijo o cliente só paga 2!", 
                        PromocaoXingredientes = new List<PromocaoXingrediente> {
                            new PromocaoXingrediente { Id = 4, PromocaoId = 3, IngredienteId = 5, Quantidade = 3, Contem = true }
                        }
                    }
                };

                context.Promocao.AddOrUpdate(promocoes.ToArray());


                // adicionando um cliente padrão para testes:
                context.Cliente.AddOrUpdate(
                    new Cliente { 
                            Id = 1, Nome = "Fulano da Silva", Apelido = "Fulano", DataCadastro = DateTime.Now, 
                            Enderecos = new List<Endereco> {
                                new Endereco { Id = 1, ClienteId = 1, CEP = "13000000", Logradouro = "Rua XYZ, 99", Bairro = "Bairro ABC", Cidade = "Campinas", Estado = "São Paulo", TipoEndereco = "Entrega 01" }
                            } 
                        }
                    );

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
