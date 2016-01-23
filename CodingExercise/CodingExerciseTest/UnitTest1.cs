using System;
using System.Collections.Generic;
using CodingExercise.Class;
using CodingExerciseTest.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingExerciseTest
{
    [TestClass]
    public class CodeTest
    {
        private FizzBuzz fizzBuzz;

        [TestInitialize]
        public void Init()
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void ProcessItem_ShouldReturnFizz_ByLowerNumber()
        {
            ItemObjectHelper item = new ItemObjectHelper() { Number = 4};

            var result = fizzBuzz.ProcessItem(item, 2, 5);

            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void ProcessItem_ShouldReturnBuzz_ByHigherNumber()
        {
            ItemObjectHelper item = new ItemObjectHelper() { Number = 15 };

            var result = fizzBuzz.ProcessItem(item, 2, 5);

            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void ProcessItem_ShouldReturnFizzBuzz_ByLowerAndHigherNumber()
        {
            ItemObjectHelper item = new ItemObjectHelper() { Number = 15 };

            var result = fizzBuzz.ProcessItem(item, 3, 5);

            Assert.AreEqual(result, "FizzBuzz"); 
        }

        [TestMethod]
        public void ProcessItem_ShouldReturnEmpty_NoDivisible()
        {
            ItemObjectHelper item = new ItemObjectHelper() { Number = 49 };

            var result = fizzBuzz.ProcessItem(item, 3, 5);

            Assert.AreEqual(result, string.Empty); 
        }

        [TestMethod]
        public void ProcessItem_ShouldReturnEmpty_DivisibleByZero()
        {
            ItemObjectHelper item = new ItemObjectHelper() { Number = 49 };

            var result = fizzBuzz.ProcessItem(item, 0, 0);

            Assert.AreEqual(result, string.Empty); 
        }

        [TestMethod]
        public void PrintLog_ShouldReturnListOfLogs()
        {
            var list = new List<ItemObjectHelper>()
                {
                    new ItemObjectHelper() {Number = 6},
                    new ItemObjectHelper() {Number = 10},
                    new ItemObjectHelper() {Number = 37},
                    new ItemObjectHelper() {Number = 15}
                };

            foreach (var item in list)
            {
                fizzBuzz.ProcessItem(item, 3, 5);
            }

            var printLog = fizzBuzz.Print();

            Assert.AreEqual(printLog[0], "Divided: 6 by: 3");
            Assert.AreEqual(printLog[1], "Divided: 10 by: 5");
            Assert.AreEqual(printLog[2], "37 - N/A");
            Assert.AreEqual(printLog[3], "Divided: 15 by: 3");
            Assert.AreEqual(printLog[4], "Divided: 15 by: 5");
        }
    }
}
