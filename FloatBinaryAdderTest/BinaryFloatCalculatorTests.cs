using Microsoft.VisualStudio.TestTools.UnitTesting;
using FloatBinaryAdder;  

namespace FloatBinaryAdderTest 
{
    [TestClass]
    public class BinaryFloatCalculatorTests
    {
        private BinaryFloatCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new BinaryFloatCalculator();
        }

        [TestMethod]
        public void Test_FloatToBinary_And_Back()
        {
            float number = 5.75f;

            string binary = calculator.FloatToBinary(number);
            float result = calculator.BinaryToFloat(binary);

            Assert.AreEqual(number, result, 0.0001f);
        }

        [TestMethod]
        public void Test_BinaryToFloat_KnownValue()
        {
            string binary = "00111111110000000000000000000000"; // 1.5f

            float result = calculator.BinaryToFloat(binary);

            Assert.AreEqual(1.5f, result, 0.0001f);
        }

        [TestMethod]
        public void Test_AddBinary_TwoPositiveIntegers()
        {
            string a = "00000000000000000000000000000101"; // 5
            string b = "00000000000000000000000000000011"; // 3

            string result = calculator.AddBinary(a, b);

            int intResult = System.Convert.ToInt32(result, 2);

            Assert.AreEqual(8, intResult);
        }

        [TestMethod]
        public void Test_AddBinary_WithCarry()
        {
            string a = "00000000000000000000000011111111"; // 255
            string b = "00000000000000000000000000000001"; // 1

            string result = calculator.AddBinary(a, b);

            int intResult = System.Convert.ToInt32(result, 2);

            Assert.AreEqual(256, intResult);
        }

        [TestMethod]
        public void Test_AddBinary_Overflow()
        {
            string a = "11111111111111111111111111111111"; // Max 32-bit unsigned
            string b = "00000000000000000000000000000001"; // 1

            string result = calculator.AddBinary(a, b);

            // Wraparound (lower 32 bits only)
            int intResult = System.Convert.ToInt32(result, 2);

            Assert.AreEqual(0, intResult);
        }
        [TestMethod]
        public void Test_AddTwoPositiveFloats()
        {
            float a = 2.5f;
            float b = 3.25f;

            float result = a + b; // direct float addition
            float expected = 5.75f;

            Assert.AreEqual(expected, result, 0.0001f);
        }

        [TestMethod]
        public void Test_AddPositiveAndNegativeFloat()
        {
            float a = 5.0f;
            float b = -2.0f;

            float result = a + b; // direct addition
            float expected = 3.0f;

            Assert.AreEqual(expected, result, 0.0001f);
        }

        [TestMethod]
        public void Test_AddSmallFloats()
        {
            float a = 0.1f;
            float b = 0.2f;

            float result = a + b;
            float expected = 0.3f;

            Assert.AreEqual(expected, result, 0.0001f); // allow floating-point tolerance
        }
    }
}
