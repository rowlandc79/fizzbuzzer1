using FizzLibrary.Model;
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


        public override Tuple<string, Model.FizzBuzzType.Type, int> GetFizzBuzzResponseWithCount(int num)
        {
            var lucky = GetLuckyWithCount(num);
            var fizz = GetFizzWithCount(num);
            var buzz = GetBuzzWithCount(num);
            var fizzbuzz = GetFizzBuzzWithCount(num);

            if (lucky.Item2 > 0)
                return new Tuple<string, FizzBuzzType.Type, int>(lucky.Item1, FizzBuzzType.Type.Lucky, lucky.Item2);
            if (fizzbuzz.Item2 > 0)
                return new Tuple<string, FizzBuzzType.Type, int>(fizzbuzz.Item1, FizzBuzzType.Type.FizzBuzz, fizzbuzz.Item2);
            if ((fizz.Item2 + buzz.Item2 + fizzbuzz.Item2) == 0)
                return new Tuple<string, FizzBuzzType.Type, int>(num.ToString(), FizzBuzzType.Type.Integer, 1);
            if (fizz.Item2 > 0)
                return new Tuple<string, FizzBuzzType.Type, int>(fizz.Item1, FizzBuzzType.Type.Fizz, fizz.Item2);
            if (buzz.Item2 > 0)
                return new Tuple<string, FizzBuzzType.Type, int>(buzz.Item1, FizzBuzzType.Type.Buzz, buzz.Item2);
            else
                return new Tuple<string, FizzBuzzType.Type, int>(num.ToString(), FizzBuzzType.Type.Integer, 1);
        }


        public string GetLucky(int num)
        {
            return GetLuckyWithCount(num).Item1;
        }

        public Tuple<string, int> GetLuckyWithCount(int num)
        {
            return (num.ToString().Contains("3")) ? new Tuple<string, int>("lucky", 1) : new Tuple<string, int>("", 0);
        }

    }
}
