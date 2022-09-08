namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade:");
        var grade = (Console.ReadLine());
        if(grade=="A")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if (grade=="B")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if (grade=="C")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if (grade=="D")
        {
            Console.WriteLine("GPA point: 1");
        }
        else if (grade=="F")
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
    }
}
