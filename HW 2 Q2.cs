namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input first num:");
            var num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input second num:");
            var num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input third num:");
            var num3 = Convert.ToInt16(Console.ReadLine());
        if (num1<num2 && num1<num3)
        {
            Console.WriteLine("The smallest value is "+num1);
        }
        else if (num2<num1 && num2<num3)
        {
            Console.WriteLine("The smallest value is "+num2);
        }
        else 
        {
            Console.WriteLine("The smallest value is "+num3);
        }
    }
}
