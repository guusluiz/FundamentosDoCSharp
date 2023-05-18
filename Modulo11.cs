namespace Modulo11;
public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2012, 12, 02, 19, 22, 23);
        var date2 = DateTime.Parse("2022/12/22 19:25:23");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));
        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);
    }
    public void AulaSubtraindoDatas()
    {
         var date1 = DateTime.Now;
         var date2 = DateTime.Parse("2022-01-01");

         //var diff = date1.Subtract(date2);
         var diff = date1 - date2;
         Console.WriteLine((int)diff.TotalDays);
         Console.WriteLine((int)diff.TotalHours);
    }
    public void AulaAdicionandoDiasMesAno()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.AddDays(3));
        Console.WriteLine(date1.AddMonths(1));
        Console.WriteLine(date1.AddYears(2));
    }
    public void AulaAdicionandoHoraMinutoSegundo()
    {
        var date1 = DateTime.Now;
        Console.WriteLine(date1.AddHours(3));
        Console.WriteLine(date1.AddMinutes(1));
        Console.WriteLine(date1.AddSeconds(2));
    }
    public void AulaDiaDaSemana()
    {
        var date1 = DateTime.Now;
        
        Console.WriteLine(date1.DayOfWeek);
    }
    public void AulaDateOnly()
    {
        var somenteData = new DateOnly(2022,12,2);

        Console.WriteLine(somenteData);
    }
    public void AulaTimeOnly()
    {
        var somenteHora = new TimeOnly(10,15,11,2);

        Console.WriteLine(somenteHora);
    }
}