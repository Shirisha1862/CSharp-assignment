using System;

namespace GreatestProductFinder
{
    public class ProductCalculator
    {
        /// <summary>
        /// Finds the greatest product of four adjacent digits in the given number string.
        /// </summary>
        /// <param name="numberString">Input number as string</param>
        /// <returns>Tuple containing product and string representation of digits multiplied</returns>
        public (int product, string digits) FindGreatestProduct(string numberString)
        {
            if (string.IsNullOrEmpty(numberString) || numberString.Length < 4)
                return (0, string.Empty);

            int maxProduct = 0;
            string maxDigits = string.Empty;

            for (int i = 0; i <= numberString.Length - 4; i++)
            {
                string currentDigits = numberString.Substring(i, 4);

                if (!IsDigitsOnly(currentDigits))
                    continue;

                int product = 1;
                foreach (char c in currentDigits)
                {
                    product *= c - '0';
                }

                if (product > maxProduct)
                {
                    maxProduct = product;
                    maxDigits = currentDigits;
                }
            }

            return (maxProduct, maxDigits);
        }

        /// <summary>
        /// Checks if the string contains only numeric digits
        /// </summary>
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}