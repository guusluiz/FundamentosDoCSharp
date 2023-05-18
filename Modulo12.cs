namespace Modulo12;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoExceptions()
    {
        while (true)
        {
            Console.Write("Informe um número: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine("Resultado: " + resultado);
        }
    }
    public void AulaTratandoExceptions()
    {
        while (true)
        {
            try
            {
                Console.Write("Informe um número: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Ocorreu um erro de divisão: " + exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Ocorreu um Erro: " + exception.Message);
                Console.WriteLine("Stack: " + exception.StackTrace);
            }

        }
    }
}