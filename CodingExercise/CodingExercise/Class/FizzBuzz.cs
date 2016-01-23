using CodingExercise.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise.Class
{
    public class FizzBuzz
    {
        private readonly IList<string> _log = new List<string>();

        public string ProcessItem(IDivisible item, int lowerNumber, int higherNumber)
        {
            try
            {
                if (item.DivideItem(lowerNumber * higherNumber) == 0)
                {
                    _log.Add(string.Format("Divided: {0} by: {1}", item.GetItem(), lowerNumber));
                    _log.Add(string.Format("Divided: {0} by: {1}", item.GetItem(), higherNumber));
                    return "FizzBuzz";
                }
                if (item.DivideItem(lowerNumber) == 0)
                {
                    _log.Add(string.Format("Divided: {0} by: {1}", item.GetItem(), lowerNumber));
                    return "Fizz";
                }
                if (item.DivideItem(higherNumber) == 0)
                {
                    _log.Add(string.Format("Divided: {0} by: {1}", item.GetItem(), higherNumber));
                    return "Buzz";
                }
            }
            catch
            {
                //Some additional operation for exceptions.
            }
            
            _log.Add(string.Format("{0} - N/A", item.GetItem()));
            return string.Empty;
        }

        public IList<string> Print()
        {
            return _log;
        }
    }
}
