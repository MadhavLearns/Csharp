using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.RuntimeHelpers
{
    public class TaxCalculator
    {
        public TaxCalculator(string license)
        {
            ValidateLicense(license);
        }

        // dummy validation for illustration only
        private void ValidateLicense(string license)
        {
            if (string.IsNullOrEmpty(license))
            {
                throw new ArgumentException("Your license is invalid, you stupid developer", nameof(license));
            }
        }

        public double CalculateVAT(double price)
        {
            return Math.Round(price * 0.22, 2);
        }
    }
}
