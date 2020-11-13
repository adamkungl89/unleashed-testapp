using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnleashedTest;

namespace MoneyWordTest
{
    [TestClass]
    public class UnitTest1
    {
        /* Test most basic input */
        [TestMethod]
        public void TestOneDollarNormal()
        {
            string result = MoneyWord.convertToWords("1.00");
            Assert.AreEqual("one dollar", result);
        }

        [TestMethod]
        public void TestOneDollarLeadingZeroes()
        {
            string result = MoneyWord.convertToWords("0001.00");
            Assert.AreEqual("one dollar", result);
        }

        [TestMethod]
        public void TestOneDollarNoCents()
        {
            string result = MoneyWord.convertToWords("1");
            Assert.AreEqual("one dollar", result);
        }

        [TestMethod]
        public void TestOneDollarOneCent()
        {
            string result = MoneyWord.convertToWords("1.01");
            Assert.AreEqual("one dollar and one cent", result);
        }

        [TestMethod]
        public void TestZeroDollarsTwoCents()
        {
            string result = MoneyWord.convertToWords("0.02");
            Assert.AreEqual("two cents", result);
        }

        [TestMethod]
        public void TestZeroZero()
        {
            string result = MoneyWord.convertToWords("0.00");
            Assert.AreEqual("zero dollars and zero cents", result);
        }

        [TestMethod]
        public void TestZero()
        {
            string result = MoneyWord.convertToWords("0");
            Assert.AreEqual("zero dollars and zero cents", result);
        }

        /* Test 2-digit dollars and cents input */
        [TestMethod]
        public void TestTwoDollars1DigitCents()
        {
            string result = MoneyWord.convertToWords("2.05");
            Assert.AreEqual("two dollars and five cents", result);
        }

        [TestMethod]
        public void TestTenDollar2DigitCentsTen()
        {
            string result = MoneyWord.convertToWords("10.10");
            Assert.AreEqual("ten dollars and ten cents", result);
        }

        [TestMethod]
        public void TestOneDollar2DigitCentsTwenty()
        {
            string result = MoneyWord.convertToWords("01.20");
            Assert.AreEqual("one dollar and twenty cents", result);
        }

        [TestMethod]
        public void TestTwentyDollar2DigitCentsTeen()
        {
            string result = MoneyWord.convertToWords("20.15");
            Assert.AreEqual("twenty dollars and fifteen cents", result);
        }

        [TestMethod]
        public void TestNinetyFiveDollar2DigitCentsTwentyFive()
        {
            string result = MoneyWord.convertToWords("25.25");
            Assert.AreEqual("twenty-five dollars and twenty-five cents", result);
        }

        /* Test hundreds */
        [TestMethod]
        public void TestOneHundred()
        {
            string result = MoneyWord.convertToWords("100.00");
            Assert.AreEqual("one hundred dollars", result);
        }

        [TestMethod]
        public void TestOneHundredAndOne()
        {
            string result = MoneyWord.convertToWords("101.00");
            Assert.AreEqual("one hundred and one dollars", result);
        }

        [TestMethod]
        public void TestOneHundredandFifty()
        {
            string result = MoneyWord.convertToWords("150.00");
            Assert.AreEqual("one hundred and fifty dollars", result);
        }

        [TestMethod]
        public void TestOneHundredandEightyFive()
        {
            string result = MoneyWord.convertToWords("185.00");
            Assert.AreEqual("one hundred and eighty-five dollars", result);
        }

        [TestMethod]
        public void TestOneHundredAndCents()
        {
            string result = MoneyWord.convertToWords("100.66");
            Assert.AreEqual("one hundred dollars and sixty-six cents", result);
        }

        [TestMethod]
        public void TestOneHundredAndSomethingAndCents()
        {
            string result = MoneyWord.convertToWords("123.45");
            Assert.AreEqual("one hundred and twenty-three dollars and forty-five cents", result);
        }

        /*Test thousands*/
        [TestMethod]
        public void TestTwoThousand()
        {
            string result = MoneyWord.convertToWords("2000.00");
            Assert.AreEqual("two thousand dollars", result);
        }

        [TestMethod]
        public void TestTwoThousandAndThree()
        {
            string result = MoneyWord.convertToWords("2003.00");
            Assert.AreEqual("two thousand and three dollars", result);
        }

        [TestMethod]
        public void TestTwoThousandandThirty()
        {
            string result = MoneyWord.convertToWords("2030.00");
            Assert.AreEqual("two thousand and thirty dollars", result);
        }

        [TestMethod]
        public void TestTwoThousandandThirtyThree()
        {
            string result = MoneyWord.convertToWords("2033.00");
            Assert.AreEqual("two thousand and thirty-three dollars", result);
        }

        [TestMethod]
        public void TestTwoThousandThreeHundred()
        {
            string result = MoneyWord.convertToWords("2300.00");
            Assert.AreEqual("two thousand, three hundred dollars", result);
        }

        [TestMethod]
        public void TestTwoThousandThreeHundredAndThree()
        {
            string result = MoneyWord.convertToWords("2303.00");
            Assert.AreEqual("two thousand, three hundred and three dollars", result);
        }

        [TestMethod]
        public void TestTwoThousandThreeHundredAndThirtyThreeAndCents()
        {
            string result = MoneyWord.convertToWords("2333.33");
            Assert.AreEqual("two thousand, three hundred and thirty-three dollars and thirty-three cents", result);
        }

        [TestMethod]
        public void TestFiftyThousand()
        {
            string result = MoneyWord.convertToWords("50000.00");
            Assert.AreEqual("fifty thousand dollars", result);
        }

        [TestMethod]
        public void TestFiftyThousandAndFive()
        {
            string result = MoneyWord.convertToWords("50005.00");
            Assert.AreEqual("fifty thousand and five dollars", result);
        }

        [TestMethod]
        public void TestFiftyFiveThousandAndFiftyFive()
        {
            string result = MoneyWord.convertToWords("55055.00");
            Assert.AreEqual("fifty-five thousand and fifty-five dollars", result);
        }

        [TestMethod]
        public void TestFiftyFiveThousandFiveHundred()
        {
            string result = MoneyWord.convertToWords("55500.00");
            Assert.AreEqual("fifty-five thousand, five hundred dollars", result);
        }

        [TestMethod]
        public void TestSixHundredThousand()
        {
            string result = MoneyWord.convertToWords("600000.00");
            Assert.AreEqual("six hundred thousand dollars", result);
        }

        [TestMethod]
        public void TestSixHundredAndSixThousand()
        {
            string result = MoneyWord.convertToWords("606000.00");
            Assert.AreEqual("six hundred and six thousand dollars", result);
        }

        [TestMethod]
        public void TestSixHundredAndSixtySixThousand()
        {
            string result = MoneyWord.convertToWords("666000.00");
            Assert.AreEqual("six hundred and sixty-six thousand dollars", result);
        }

        /*Test millions*/
        [TestMethod]
        public void TestNineMillion()
        {
            string result = MoneyWord.convertToWords("9000000.00");
            Assert.AreEqual("nine million dollars", result);
        }

        [TestMethod]
        public void TestNinetyMillion()
        {
            string result = MoneyWord.convertToWords("90000000.00");
            Assert.AreEqual("ninety million dollars", result);
        }

        [TestMethod]
        public void TestNineHundredMillion()
        {
            string result = MoneyWord.convertToWords("900000000.00");
            Assert.AreEqual("nine hundred million dollars", result);
        }

        [TestMethod]
        public void TestNineHundredAndNinetyMillion()
        {
            string result = MoneyWord.convertToWords("990000000.00");
            Assert.AreEqual("nine hundred and ninety million dollars", result);
        }

        [TestMethod]
        public void TestNineHundredAndNinetyNineMillion()
        {
            string result = MoneyWord.convertToWords("999000000.00");
            Assert.AreEqual("nine hundred and ninety-nine million dollars", result);
        }

        [TestMethod]
        public void TestNineHundredAndNinetyNineMillion900000()
        {
            string result = MoneyWord.convertToWords("999900000.00");
            Assert.AreEqual("nine hundred and ninety-nine million, nine hundred thousand dollars", result);
        }

        [TestMethod]
        public void TestNineHundredAndNinetyNineMillion980000()
        {
            string result = MoneyWord.convertToWords("999980000.00");
            Assert.AreEqual("nine hundred and ninety-nine million, nine hundred and eighty thousand dollars", result);
        }

        [TestMethod]
        public void TestNineHundredAndNinetyNineMillion987000()
        {
            string result = MoneyWord.convertToWords("999987000.00");
            Assert.AreEqual("nine hundred and ninety-nine million, nine hundred and eighty-seven thousand dollars", result);
        }

        [TestMethod]
        public void TestNineHundredAndNinetyNineMillion987600()
        {
            string result = MoneyWord.convertToWords("999987600.00");
            Assert.AreEqual("nine hundred and ninety-nine million, nine hundred and eighty-seven thousand, six hundred dollars", result);
        }
        
        [TestMethod]
        public void TestNineHundredAndNinetyNineMillion987650()
        {
            string result = MoneyWord.convertToWords("999987650.00");
            Assert.AreEqual("nine hundred and ninety-nine million, nine hundred and eighty-seven thousand, six hundred and fifty dollars", result);
        }

        [TestMethod]
        public void TestNineHundredAndNinetyNineMillion987654()
        {
            string result = MoneyWord.convertToWords("999987654.00");
            Assert.AreEqual("nine hundred and ninety-nine million, nine hundred and eighty-seven thousand, six hundred and fifty-four dollars", result);
        }

        [TestMethod]
        public void TestNineHundredAndNinetyNineMillion987654cents()
        {
            string result = MoneyWord.convertToWords("999987654.32");
            Assert.AreEqual("nine hundred and ninety-nine million, nine hundred and eighty-seven thousand, six hundred and fifty-four dollars and thirty-two cents", result);
        }

        [TestMethod]
        public void TestNineHundredMillionAndOne()
        {
            string result = MoneyWord.convertToWords("900000001");
            Assert.AreEqual("nine hundred million and one dollars", result);
        }

        /* Input Validation Errors */
        [TestMethod]
        public void TestNonNumericInput()
        {
            string result = MoneyWord.convertToWords("ten.00");
            Assert.AreEqual("Error: Bad input", result);
        }

        [TestMethod]
        public void TestTooLongInput()
        {
            string result = MoneyWord.convertToWords("1234567891.00");
            Assert.AreEqual("Error: Bad input", result);
        }

        [TestMethod]
        public void TestTooLongCentsInput()
        {
            string result = MoneyWord.convertToWords("100.001");
            Assert.AreEqual("Error: Bad input", result);
        }

        [TestMethod]
        public void TestTooShortCentsInput()
        {
            string result = MoneyWord.convertToWords("100.1");
            Assert.AreEqual("Error: Bad input", result);
        }

        [TestMethod]
        public void TestNoDollarsInput()
        {
            string result = MoneyWord.convertToWords(".10");
            Assert.AreEqual("Error: Bad input", result);
        }
    }

    
}
