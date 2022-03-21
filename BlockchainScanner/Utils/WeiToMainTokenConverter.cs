using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainScanner.Utils
{
    public static class WeiToMainTokenConverter
    {
        public static double Convert(string value)
        {
            return double.Parse(value) / Math.Pow(10, 18);
        }

        public static double Convert(double value)
        {
            return value / Math.Pow(10, 18);
        }
    }
}