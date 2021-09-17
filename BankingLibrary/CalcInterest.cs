using System;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest
    {
    public int Calculate(int principle, int rateofint, int years)
    {
        int SimpleInt = (principle * rateofint * years) / 100;
        return SimpleInt; 
    }
    }
}
