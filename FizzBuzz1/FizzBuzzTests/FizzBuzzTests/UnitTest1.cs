using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            FizzLibrary.Fizzer fizzer = new FizzLibrary.Fizzer();

            Assert.AreEqual("1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz", fizzer.GoFizz(1,20));


        }
    }
}
