using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingExercise.Interface;

namespace CodingExerciseTest.Helper
{
    class ItemObjectHelper : IDivisible
    {
        public int Number { get; set; }

        public int GetItem()
        {
            return Number;
        }

        public int DivideItem(int number)
        {
            return Number % number;
        }
    }
}
