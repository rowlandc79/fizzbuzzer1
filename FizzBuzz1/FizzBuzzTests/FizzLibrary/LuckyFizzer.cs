using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibrary
{
    /// <summary>
    /// Overrides default fizzer functionality, introducing the Lucky functionality
    /// </summary>
    public class LuckyFizzer : Fizzer
    {
        public override string GetFizzBuzzResponse(int num)
        {
            string lucky = GetLucky(num);
            string fizz = GetFizz(num);
            string buzz = GetBuzz(num);
            string fizzbuzz = GetFizzBuzz(num);

            if (lucky != "")
                return lucky;
            if (fizzbuzz != "")
                return fizzbuzz;
            if ((fizz + buzz + fizzbuzz) == "")
                return num.ToString();
            else
                return (fizz + buzz + fizzbuzz);
        }

        public string GetLucky(int num)
        {
            return (num.ToString().Contains("3")) ? "lucky" : "";
        }

    }
}
