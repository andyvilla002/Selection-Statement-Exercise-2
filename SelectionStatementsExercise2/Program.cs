using static System.Formats.Asn1.AsnWriter;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is your favorite school subject?");
            var userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "science":
                    Console.WriteLine("Future rocket scientist!");
                    break;
                case "math":
                    Console.WriteLine("No need for a calculator");
                    break;
                case "p.e.":
                    Console.WriteLine("Don't forget your gym bag");
                    break;
                case "english":
                    Console.WriteLine("Can't get enough reading huh?");
                    break;
                case "social studies":
                    Console.WriteLine("These notes go in a blue folder");
                    break;
                default:
                    Console.WriteLine($"Haven't heard of that classs yet! {userInput} sounds fun!");
                    break;
            }
        }
    }
}