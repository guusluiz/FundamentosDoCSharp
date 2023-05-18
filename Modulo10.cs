namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }
    public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }
    public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(6,5));
    }
    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        string extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);
        string nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);
        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }
    public void AulaContains()
    {
        string nomeArqueivo = "2022_12_01_backup.bak";
        if(nomeArqueivo.Contains("backup"))
        {
            Console.WriteLine("Palavra encontrada");
        }
        else
        {
            Console.WriteLine("Palavra não encontrada");
        }
        //Console.WriteLine("Contem nome: " + nomeArqueivo.Contains("backup"));
    }
    public void AulaTrim()
    {
        string teste = "**GUSTAVO LUIZ**";
        Console.WriteLine("TOTAL: " + teste.Trim('*'));
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));
        Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
    }
    public void AulaStartWithEndsWith()
    {
        string teste = "Curso Csharp";
        Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
        Console.WriteLine("FINAL: " + teste.EndsWith("Csharp02"));
    }
    public void AulaReplace()
    {
        string teste = "Curso Csharp";
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Csharp","C#"));
    }
    public void AulaLength()
    {
        string teste = Console.ReadLine();
        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);
    }
}