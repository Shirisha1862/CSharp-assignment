using System;

namespace FloatBinaryAdder
{
    public class BinaryFloatCalculator
    {
        /// <summary>
        /// Converts a float number to its 32-bit binary string representation.
        /// </summary>
        public string FloatToBinary(float number)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            Array.Reverse(bytes); // MSB first

            string binary = "";
            foreach (byte b in bytes)
                binary += Convert.ToString(b, 2).PadLeft(8, '0');

            return binary;
        }

        /// <summary>
        /// Converts a 32-bit binary string to its float representation.
        /// </summary>
        public float BinaryToFloat(string binary)
        {
            byte[] bytes = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                bytes[3 - i] = Convert.ToByte(binary.Substring(i * 8, 8), 2);
            }

            return BitConverter.ToSingle(bytes, 0);
        }

        /// <summary>
        ///Adds two 32-bit binary strings and returns the 32-bit sum as binary string.
        /// </summary>
        public string AddBinary(string a, string b)
        {
            string result = "";
            int carry = 0;
            int i = a.Length - 1, j = b.Length - 1;

            while (i >= 0 || j >= 0 || carry == 1)
            {
                int sum = carry;

                if (i >= 0)
                    sum += a[i--] - '0';

                if (j >= 0)
                    sum += b[j--] - '0';

                result = (sum % 2) + result;
                carry = sum / 2;
            }

            // Ensure 32-bit representation
            return result.PadLeft(32, '0').Substring(result.Length - 32);
        }
    }
}
