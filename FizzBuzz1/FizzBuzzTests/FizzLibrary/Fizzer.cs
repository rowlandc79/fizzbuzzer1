﻿using FizzLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibrary
{
    public abstract class Fizzer
    {

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
            FizzBuzzResponse response = new FizzBuzzResponse();

            FizzBuzzType.Type myType = FizzBuzzType.Type.Integer;
            int myCount = 0;
            string myFizz = "";

            for (int i = startNum; i <= endNum; i++)
            {
                if (myFizz == "")
                { 
                    var resp = GetFizzBuzzResponseWithCount(i);
                    response.Value = resp.Item1;
                    myType = resp.Item2;
                    myCount = resp.Item3;
                }
                else
                {
                    var resp = GetFizzBuzzResponseWithCount(i);
                    response.Value += " " + resp.Item1;
                    myType = resp.Item2;
                    myCount = resp.Item3;
                }
            }

            return response;
        }

        public virtual Tuple<string, Model.FizzBuzzType.Type, int> GetFizzBuzzResponseWithCount(int num)
        {
            //string fizz = GetFizz(num);
            //string buzz = GetBuzz(num);
            //string fizzbuzz = GetFizzBuzz(num);

            //if (fizzbuzz != "")
            //    return fizzbuzz;
            //if ((fizz + buzz + fizzbuzz) == "")
            //    return num.ToString();
            //else
            //    return (fizz + buzz + fizzbuzz);

            throw new NotImplementedException();
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
            return (num % 3 == 0) ? "fizz" : "";
        }
        public string GetBuzz(int num)
        {
            return (num % 5 == 0) ? "buzz" : "";
        }
        public string GetFizzBuzz(int num)
        {
            return (num % 15 == 0) ? "fizzbuzz" : "";
        }


        public string GetFizzWithCount(int num)
        {
            return (num % 3 == 0) ? "fizz" : "";
        }
        public string GetBuzzWithCount(int num)
        {
            return (num % 5 == 0) ? "buzz" : "";
        }
        public string GetFizzBuzzWithCount(int num)
        {
            return (num % 15 == 0) ? "fizzbuzz" : "";
        }


    }
}
