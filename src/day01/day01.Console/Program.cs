﻿using System;
using System.Collections.Generic;
using System.Linq;
using day02.Common;

namespace day02
{
    class Program
    {
        private struct CounterUpperRecord
        {
            public int Mass { get; set; }
            public int RequiredFuel { get; set; }
        }

        private static void Main(string[] args)
        {
            var inputData = new int[] {
                129315, 138428, 85143, 119378, 106438, 136138, 126273, 61726, 117121, 107510,
                116139, 137089, 62862, 89101, 91623, 121912, 113802, 68527, 106791, 71526, 80210,
                140968, 116768, 114069, 74451, 72109, 89284, 65098, 76986, 52739, 106469, 112964,
                133216, 110269, 70285, 52893, 134567, 70332, 51686, 116308, 132269, 101578,
                69560, 137966, 108829, 94394, 64614, 77959, 86005, 112014, 54597, 108355, 82805,
                54025, 50093, 139350, 89057, 108119, 149167, 90273, 83649, 58058, 59560, 63756,
                78767, 112689, 59109, 103073, 97051, 122663, 59326, 63315, 105423, 134811,
                89578, 105967, 112749, 77245, 146275, 97078, 146862, 75927, 124553, 103857,
                125861, 131980, 60928, 109846, 128001, 71441, 101655, 110244, 100550, 149770,
                80374, 76230, 70359, 113471, 143101, 148859};

            var counterUpperData = new List<CounterUpperRecord>();

            foreach (var mass in inputData)
            {
                var record = new CounterUpperRecord { Mass = mass, RequiredFuel = FuelCalculator.CalcWithFuel(mass) };
                counterUpperData.Add(record);
            }

            var sum = counterUpperData.Sum(r => r.RequiredFuel);

            // 3287620
            Console.WriteLine($"The sum of required fuel is {sum}.");
            Console.ReadKey();
        }
    }
}
