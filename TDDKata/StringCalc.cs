// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Linq;

namespace TDDKata
{
    internal class StringCalc
    {
        private static char[] DELIMITERS = { ',', '\n' };

        internal int Sum(string v)
        {
            if (string.IsNullOrWhiteSpace(v))
                return -1;

            string[] args = v.Split(DELIMITERS, StringSplitOptions.None);

            var hasNotDigitChar = args.Any(arg => string.IsNullOrWhiteSpace(arg) || arg.Any(x => !Char.IsDigit(x)));
            if (hasNotDigitChar)
                return -1;

            var operands = args.Select(x => Int32.Parse(x));

            var result = operands.Sum();

            return result;
        }
    }
}