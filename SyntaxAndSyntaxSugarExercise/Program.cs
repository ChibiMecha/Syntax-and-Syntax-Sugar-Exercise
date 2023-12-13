using System.Globalization;
using System.Runtime.CompilerServices;

namespace SyntaxAndSyntaxSugarExercise
{
//     <!-- ## Exercise 1:
// Given the following code, change the code to implement:

// + inferred typing
// + string interpolation
// + and the ternary operator
// ```
// int answer = 4;
// string response;
// if (answer < 9) 
// {
//     response = answer + " is less than nine";
// }
// else
// {
//     response = answer + " is greater than or equal to nine";
// }
// ``` -->
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number:1-9");
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);
        }
    }
}
