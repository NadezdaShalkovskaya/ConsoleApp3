using System.Linq.Expressions;

try
{
    Console.WriteLine("Введите число n>999");
    int n = int.Parse(Console.ReadLine());
    double a = n / 100;
    Console.WriteLine($"вот столько сотен в n{a}");
    double b = n / 1000;
    Console.WriteLine($"вот столько тысяч в n {b}");
}
catch
{
    Console.WriteLine("Error");
}