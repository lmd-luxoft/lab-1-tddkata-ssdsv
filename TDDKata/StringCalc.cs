// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Linq;

namespace TDDKata
{
    internal class StringCalc
    {
        private const char DELIMITER = ',';
        internal int Sum(string v)
        {
            if (string.IsNullOrWhiteSpace(v))
                return -1;

            string[] args = v.Split(new[] { DELIMITER }, StringSplitOptions.None);

            if (args.Length > 2)
                return -1;

            var hasNotDigitChar = args.Any(arg => string.IsNullOrWhiteSpace(arg) || arg.Any(x => !Char.IsDigit(x)));
            if (hasNotDigitChar)
                return -1;

            int arg1 = Int32.Parse(args[0]);
            if (args.Length == 1)
                return arg1;

            int arg2 = Int32.Parse(args[1]);

            return arg1 + arg2;
        }
    }
}