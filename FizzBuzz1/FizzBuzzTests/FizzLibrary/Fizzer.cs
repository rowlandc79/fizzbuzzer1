using FizzLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibrary
{
    public abstract class Fizzer
    {
        FizzBuzzResponse response;

        /// <summary>
        /// Loops from startNum to endNum, calling GetAFizz for each item
        /// </summary>
        /// <param name="startNum"></param>
        /// <param name="endNum"></param>
        /// <returns></returns>
        public string GoFizz(int startNum, int endNum)
        {
            string myFizz = "";

            for (int i=startNum; i<= endNum; i++)
            {
                if (myFizz == "")
                    myFizz = GetFizzBuzzResponse(i);
                else
                    myFizz += " " + GetFizzBuzzResponse(i);
            }

            return myFizz;
        }


        /// <summary>
        /// Loops from startNum to endNum, calling GetAFizz for each item (returns a tuple of value, type and count)
        /// </summary>
        /// <param name="startNum"></param>
        /// <param name="endNum"></param>
        /// <returns></returns>
        public FizzBuzzResponse GoFizzWithCount(int startNum, int endNum)
        {
            for (int i = startNum; i <= endNum; i++)
            {
                var resp = GetFizzBuzzResponseWithCount(i);

                if (response == null)
                {
                    response = new FizzBuzzResponse();

                    response.Value = resp.Item1;
                    if (response.TypesIndex.Any(s => s.Key == resp.Item2))
                        response.TypesIndex[resp.Item2] += resp.Item3;
                    else
                        response.TypesIndex.Add(resp.Item2, resp.Item3);
                }
                else
                {
                    response.Value += " " + resp.Item1;
                    if (response.TypesIndex.Any(s => s.Key == resp.Item2))
                        response.TypesIndex[resp.Item2] += resp.Item3;
                    else
                        response.TypesIndex.Add(resp.Item2, resp.Item3);
                }
            }

            return response;
        }

        public virtual Tuple<string, Model.FizzBuzzType.Type, int> GetFizzBuzzResponseWithCount(int num)
        {
            var fizz = GetFizzWithCount(num);
            var buzz = GetBuzzWithCount(num);
            var fizzbuzz = GetFizzBuzzWithCount(num);

            if (fizzbuzz.Item2 > 0)
                return new Tuple<string, FizzBuzzType.Type, int>(fizzbuzz.Item1,FizzBuzzType.Type.FizzBuzz,fizzbuzz.Item2);
            if ((fizz.Item2 + buzz.Item2 + fizzbuzz.Item2) == 0)
                return new Tuple<string, FizzBuzzType.Type, int>(num.ToString(), FizzBuzzType.Type.Integer, 1);
            if (fizz.Item2 > 0)
                    return new Tuple<string, FizzBuzzType.Type, int>(fizz.Item1, FizzBuzzType.Type.Fizz, fizz.Item2);
            if (buzz.Item2 > 0)
                return new Tuple<string, FizzBuzzType.Type, int>(buzz.Item1, FizzBuzzType.Type.Buzz, buzz.Item2);
            else
                return new Tuple<string, FizzBuzzType.Type, int>(num.ToString(), FizzBuzzType.Type.Integer, 1);
        }



        public virtual string GetFizzBuzzResponse(int num)
        {
            string fizz = GetFizz(num);
            string buzz = GetBuzz(num);
            string fizzbuzz = GetFizzBuzz(num);

            if (fizzbuzz != "")
                return fizzbuzz;
            if ((fizz + buzz + fizzbuzz) == "")
                return num.ToString();
            else
                return (fizz + buzz + fizzbuzz);
        }

        public string GetFizz(int num)
        {
            return GetFizzWithCount(num).Item1;
        }
        public string GetBuzz(int num)
        {
            return GetBuzzWithCount(num).Item1;
        }
        public string GetFizzBuzz(int num)
        {
            return GetFizzBuzzWithCount(num).Item1;
        }


        public Tuple<string,int> GetFizzWithCount(int num)
        {
            return (num % 3 == 0) ? new Tuple<string, int>("fizz",1) : new Tuple<string, int>("", 0);
        }
        public Tuple<string, int> GetBuzzWithCount(int num)
        {
            return (num % 5 == 0) ? new Tuple<string, int>("buzz", 1) : new Tuple<string, int>("", 0);
        }
        public Tuple<string, int> GetFizzBuzzWithCount(int num)
        {
            return (num % 15 == 0) ? new Tuple<string, int>("fizzbuzz", 1) : new Tuple<string, int>("", 0);
        }


    }
}
