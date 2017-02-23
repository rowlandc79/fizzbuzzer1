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
            FizzLibrary.Fizzer fizzer = new FizzLibrary.Fizzer();
            Assert.AreEqual("1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz", fizzer.GoFizz(1, 20));
        }


        /// <summary>
        /// test for string values of numeric inputs
        /// </summary>
        [TestMethod]
        public void TestMethodDefault()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.Fizzer();

            Assert.AreEqual("1", fizzer.GetAFizz(1));

            Assert.AreEqual("7", fizzer.GetAFizz(7));

            Assert.AreEqual("12", fizzer.GetAFizz(12));
        }



        /// <summary>
        /// test for fizz
        /// </summary>
        [TestMethod]
        public void TestMethodFizz()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.Fizzer();

            Assert.AreEqual("fizz", fizzer.GetAFizz(3));
            Assert.AreEqual("fizz", fizzer.GetAFizz(6));
            Assert.AreEqual("fizz", fizzer.GetAFizz(9));
        }

        /// <summary>
        /// test for buzz
        /// </summary>
        [TestMethod]
        public void TestMethodBuzz()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.Fizzer();

            Assert.AreEqual("buzz", fizzer.GetAFizz(5));
            Assert.AreEqual("buzz", fizzer.GetAFizz(10));
            Assert.AreEqual("buzz", fizzer.GetAFizz(15));  //careful here...once fizzbuzz is done, this one should fail
            Assert.AreEqual("buzz", fizzer.GetAFizz(20));
        }

        /// <summary>
        /// test for fizzbuzz
        /// </summary>
        [TestMethod]
        public void TestMethodFizzBuzz()
        {
            FizzLibrary.Fizzer fizzer = new FizzLibrary.Fizzer();

            Assert.AreEqual("fizzbuzz", fizzer.GetAFizz(15));
            Assert.AreEqual("fizzbuzz", fizzer.GetAFizz(30));
            Assert.AreEqual("fizzbuzz", fizzer.GetAFizz(75));
        }





    }
}
