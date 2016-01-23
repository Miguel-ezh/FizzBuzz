using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingExercise.Class;

namespace CodingExercise
{
    class Program
    { 

        static void Main(string[] args)
        {
            var FizzBuzz = new FizzBuzz();
            var list = new List<NumericObject>()
                {
                    new NumericObject() {Number = 6},
                    new NumericObject() {Number = 10},
                    new NumericObject() {Number = 37},
                    new NumericObject() {Number = 15}
                };

            foreach (var item in list)
            {
                var result = FizzBuzz.ProcessItem(item, 3, 5);
                if (!string.IsNullOrEmpty(result))
                {
                    Console.WriteLine(result);
                }
            }
            foreach (var log in FizzBuzz.Print())
            {
                Console.WriteLine(log);
            }

            Console.ReadKey();
        }
    }
}
