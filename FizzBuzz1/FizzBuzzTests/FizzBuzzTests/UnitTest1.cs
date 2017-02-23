using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// really high level text check - this will be the last to pass
        /// </summary>
        [TestMethod]
        public void TestMethodTopLevel()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.DefaultFizzer();
            Assert.AreEqual("1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz", fizzer.GoFizz(1, 20));
        }

        /// <summary>
        /// really high level text check - this will be the last to pass
        /// </summary>
        [TestMethod]
        public void TestMethodTopLevelLucky()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.LuckyFizzer();
            Assert.AreEqual("1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz", fizzer.GoFizz(1, 20));
        }



        /// <summary>
        /// really high level text check - this will be the last to pass
        /// </summary>
        [TestMethod]
        public void TestMethodTopLevelLuckyWithCounts()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.LuckyFizzer();

            var response = fizzer.GoFizzWithCount(1, 20);

            Assert.AreEqual("1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz", response.Value);

            //GoFizzWithCount needs to return a collection of types and counts within the response object...decided at this point the complexity warants a proper object

            Assert.AreEqual(4,response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.Fizz));
            Assert.AreEqual(3, response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.Buzz));
            Assert.AreEqual(1, response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.FizzBuzz));
            Assert.AreEqual(2, response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.Lucky));
            Assert.AreEqual(10, response.GetTypeCount(FizzLibrary.Model.FizzBuzzType.Type.Integer));

        }







        /// <summary>
        /// test for string values of numeric inputs
        /// </summary>
        [TestMethod]
        public void TestMethodDefault()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.DefaultFizzer();

            Assert.AreEqual("1", fizzer.GetFizzBuzzResponse(1));

            Assert.AreEqual("7", fizzer.GetFizzBuzzResponse(7));

            Assert.AreEqual("13", fizzer.GetFizzBuzzResponse(13));
        }



        /// <summary>
        /// test for fizz
        /// </summary>
        [TestMethod]
        public void TestMethodFizz()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.DefaultFizzer();

            Assert.AreEqual("fizz", fizzer.GetFizzBuzzResponse(3));
            Assert.AreEqual("fizz", fizzer.GetFizzBuzzResponse(6));
            Assert.AreEqual("fizz", fizzer.GetFizzBuzzResponse(9));
        }

        /// <summary>
        /// test for buzz
        /// </summary>
        [TestMethod]
        public void TestMethodBuzz()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.DefaultFizzer();

            Assert.AreEqual("buzz", fizzer.GetFizzBuzzResponse(5));
            Assert.AreEqual("buzz", fizzer.GetFizzBuzzResponse(10));
            Assert.AreEqual("buzz", fizzer.GetFizzBuzzResponse(20));
        }

        /// <summary>
        /// test for fizzbuzz
        /// </summary>
        [TestMethod]
        public void TestMethodFizzBuzz()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.DefaultFizzer();

            Assert.AreEqual("fizzbuzz", fizzer.GetFizzBuzzResponse(15));
            Assert.AreEqual("fizzbuzz", fizzer.GetFizzBuzzResponse(30));
            Assert.AreEqual("fizzbuzz", fizzer.GetFizzBuzzResponse(75));
        }





    }
}
