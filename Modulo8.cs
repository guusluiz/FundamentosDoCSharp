//namespace Cadastro;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }
    public class Produto
    {
        private int Id;
        public string Descricao { get; set; }

        //public readonly int Estoque;
        public int Estoque { get; }
        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }
    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cep: " + Cep);
            Console.WriteLine("Cidade: " + Cidade);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + Cpf);
        }
    }
    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }

    public sealed class Configuracao //"sealed" (selada) outras classes não podem herdar seus comportamentos e atributos (mas pode ser instanciada)
    {
        public string Host { get; set; }
    }

    public abstract class Animal // "abstract" (abstrato) não pode ser instanciado mas pode ser herdado e seus filhos serem instanciados
    {
        public string Nome { get; set; }

        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome do animal: " + Nome);
            Console.WriteLine("Informacoes: " + GetInformacoes());
        }
    }
    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }

    public record Curso(int Id, string Descricao);

    public class CursoTeste
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

    /*
    public record Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }
            return base.Equals(obj);
        }
        public static bool operator ==(Curso a, Curso b)
        {
            return a.Equals(b);

        }
        public static bool operator !=(Curso a, Curso b)
        {
            return !(a == b);
        }
    }
    */

    public interface INotificacao // "interface"(interface) faz com que classes que herdaram dela tenham que implementar seus metodos e atributos (não pode ser instanciada diretamente)
    {
        string Descricao { get; set; }
        void Notificar();
    }

    public class NotificarcaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando cliente");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros");
        }
    }
    public class NotificarcaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando funcionario");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros");
        }
    }
}