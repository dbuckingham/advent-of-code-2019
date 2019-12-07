using System;

namespace day02.Common
{
    public static class FuelCalculator
    {
        public static int Calc(int mass)
        {
            return mass / 3 - 2;
        }

        public static int CalcWithFuel(int mass)
        {
            var result = mass / 3 - 2;

            if(result <= 0) result = 0;

            System.Diagnostics.Debug.WriteLine($"mass = {mass}, fuel = {result}");

            if (result > 0){
                result = result + CalcWithFuel(result);
            } 

            return result;
        }
    }
}
