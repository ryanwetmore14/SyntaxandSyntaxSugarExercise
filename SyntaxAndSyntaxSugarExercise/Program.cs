using System.Runtime.CompilerServices;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than 9";
            Console.WriteLine(response);

            var answer2 = 20;
            var response2 = (answer2 > 9) ? $"{answer2} is greater than 9" : $"{answer2} is less than 9";
            Console.WriteLine(response2); 

        }
    }
}

