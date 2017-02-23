using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibrary
{
    public class Fizzer
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

        public string GetFizzBuzzResponse(int num)
        {
            return num.ToString();
        }
    }
}
