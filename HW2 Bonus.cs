namespace Bonus;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a year:");
        var year = Convert.ToInt16(Console.ReadLine());
    if ((year%4 == 0 && year%100 != 0) || (year%400 == 0))
    {
        Console.WriteLine(year +" is a leap year");
    }
    else 
        {Console.WriteLine(year +" is not a leap year");}
    }
}
