using System;


/*
namespace Cadastro
{
    public class Cliente
    {
    }
    public class Funcionario
    {
    }
}
namespace Financeiro
{
    public class ContasReceber
    {
    }
    public class Funcionario
    {
    }
}
*/
namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AulaClasses();
            //AulaPropriedadeSomenteLeitura();
            //AulaHeranca();
            //AulaClassesSelada();
            //AulaClassesAbstrata();
            //AulaRecord();
            //AulaInterface();
            //Conversor();
            //TrabalhandoComStrings();
            //TrabalhandoComDatas();
            //TrabalhandoComExcecoes();
            //TrabalhandoComArquivos();
            TrabalhandoComLinq();
        }
        private static void TrabalhandoComLinq()
        {
            var linq = new Modulo14.TrabalhandoComLinq();
            //linq.AulaWhere();
            //linq.AulaOrdenacao();
            //linq.AulaTake();
            //linq.AulaCount();
            linq.AulaFirstEFirstOrDefault();
        }
        private static void TrabalhandoComArquivos()
        {
            var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
            //trabalhandoComArquivos.AulaCriandoArquivo();
            //trabalhandoComArquivos.AulaLendoArquivo();
            trabalhandoComArquivos.AulaExcluindoArquivo();
        }
        private static void TrabalhandoComExcecoes()
        {
            var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExcecoes();
            ///trabalhandoComExcecoes.AulaGerandoExceptions();
            trabalhandoComExcecoes.AulaTratandoExceptions();
        }
        private static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
            //trabalhandoComDatas.AulaDateTime();
            //trabalhandoComDatas.AulaSubtraindoDatas();
            //trabalhandoComDatas.AulaAdicionandoDiasMesAno();
            //trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundo();
            //rabalhandoComDatas.AulaDiaDaSemana();
            //trabalhandoComDatas.AulaDateOnly();
            trabalhandoComDatas.AulaTimeOnly();
        }
        private static void TrabalhandoComStrings()
        {
            var TrabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
            //TrabalhandoComStrings.ConverterParaLetrasMinusculas();
            //TrabalhandoComStrings.ConverterParaLetrasMaiusculas();
            //TrabalhandoComStrings.AulaSubstring();
            TrabalhandoComStrings.AulaRange();
            //TrabalhandoComStrings.AulaContains();
            //TrabalhandoComStrings.AulaTrim();
            //TrabalhandoComStrings.AulaStartWithEndsWith();
            //TrabalhandoComStrings.AulaReplace();
            //TrabalhandoComStrings.AulaLength();
        }
        private static void Conversor()
        {
            var conversor = new Conversores.Conversor();
            //conversor.ConvertAndParse();
            conversor.AulaTryParse();
        }

        private static void AulaInterface()
        {
            var NotificarcaoCliente = new Cadastro.NotificarcaoCliente();
            NotificarcaoCliente.Notificar();

            Cadastro.INotificacao notificacao = new Cadastro.NotificarcaoFuncionario();
            notificacao.Notificar();
        }
        private static void AulaRecord()
        {
            // var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};
            // var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};

            var curso1 = new Cadastro.Curso(1, "Curso");
            var curso2 = curso1 with {Descricao = "Teste Novo"};

            //var curso1 = new Cadastro.CursoTeste { Id= 1, Descricao = "Curso"};
            //var curso2 = curso1;
            //curso1.Descricao = "TESTE TESTE";
            //var curso2 = new Cadastro.CursoTeste();
            //curso2.Id = curso1.Id;
            //curso2.Descricao = "Nova descricao";

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);
            // Console.WriteLine(curso1.Equals(curso2));
            //Console.WriteLine(curso1 == curso2);
        }
        private static void AulaClassesAbstrata()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Dog";
            cachorro.ImprimirDados();
        }
        private static void AulaClassesSelada()
        {
            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);
        }
        private static void AulaHeranca()
        {
            /*
            var funcionario = new Cadastro.Funcionario();
            funcionario.Id = 10;
            funcionario.Endereco = "Endereco Teste";
            funcionario.Cidade = "Cidade Teste";
            funcionario.Cep = "12345612";
            funcionario.Cpf = "12235233612";

            funcionario.ImprimirDados();
            funcionario.ImprimirCpf();
        }
        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
            Console.WriteLine(resultado);
            /*
            var produto = new Cadastro.Produto();
            produto.SetId(1);
            produto.Descricao = "Teclado";

            produto.ImprimirDescricao();
            Console.WriteLine(produto.GetId());
            */
        }
        private static void AulaPropriedadeSomenteLeitura()
        {
            /*var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse";
            //produto.Estoque = 1;
            Console.WriteLine(produto.Estoque);*/
        }
    }
}