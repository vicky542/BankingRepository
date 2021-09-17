using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class CalcInterest:ICalcInterest
    {
        public int Calculate(int principle,int rate,int years)
        {
            int SimpleInt = (principle * rate * years)/100;
            return SimpleInt;
        }
    }
}
