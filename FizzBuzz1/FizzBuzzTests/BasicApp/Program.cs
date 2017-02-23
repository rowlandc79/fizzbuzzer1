using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApp
{
    class Program
    {
        static void Main(string[] args)
        {

            FizzLibrary.Fizzer fizzer = new FizzLibrary.LuckyFizzer();

            Console.WriteLine("Please enter a start number: ");

            try { 
                int startNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter an end number: ");
                int endNum = Convert.ToInt32(Console.ReadLine());

                var response = fizzer.GoFizzWithCount(startNum, endNum);



                Console.WriteLine(response.Value);

                Console.WriteLine("fizz: " + response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.Fizz));
                Console.WriteLine("buzz: " + response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.Buzz));
                Console.WriteLine("fizzbuzz: " + response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.FizzBuzz));
                Console.WriteLine("lucky: " + response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.Lucky));
                Console.WriteLine("integer: " + response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.Integer));

            }
            catch(Exception exception)
            {
                Console.WriteLine("Sorry, you didn't enter a valid integer, please run the app again.");
            }

            Console.ReadLine();

        }
    }
}
