using System;

namespace WebApi.Services
{
    public static class BinaryConversionHelper
    {
        public static int BinaryToDecimal(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException($"'{nameof(input)}' cannot be null or whitespace.", nameof(input));

            if (!IsBinary(input))
                throw new ArgumentException($"'{nameof(input)}' must be a binary.", nameof(input));

            char[] array = input.ToCharArray();
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }

            }

            return sum;
        }

        public static string DecimalToBinary(int input)
        {
            int remainder;
            string result = string.Empty;
            
            while (input > 0)
            {
                remainder = input % 2;
                input /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }

        private static bool IsBinary(string s)
        {
            foreach (var c in s)
                if (c != '0' && c != '1')
                    return false;
            return true;
        }
    }
}