using UserRegistration;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("", "Input should not be empty or null")]
        [DataRow("Ab", "Try again!Please keep 3 characters minimum and atleast 1 letter as capital.")]
        public void FirstName(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.FirstName(userInput);

            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("", "Input should not be empty or null")]
        [DataRow("Ab", "Try again!Please keep 3 characters minimum and atleast 1 letter as capital.")]
        public void LastName(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.LastName(userInput);

            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("", "Input should not be empty or null")]
        [DataRow("abc@gmail.com.aa.au", "Entered Email ID is not in proper format .Please try again with something different.")]
        public void EmailId(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.EmailId(userInput);
            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("91 0923252352", "Entered Mobile No is not in proper format.It shall be like 91 **********")]
        [DataRow("919239323783 ", "Entered Mobile No is not in proper format.It shall be like 91 **********")]
        public void MobileNumber(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.MobileNumber(userInput);
            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("1234567", "Entered password doesn't meet the password policy.There must be atleast 8 characters")]
        [DataRow("Abc123", "Entered password doesn't meet the password policy.There must be atleast 8 characters")]
        public void PassMin8Char(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.PassMin8Char(userInput);
            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("a2345678", "Try Again !There must be atleast 8 characters including atleast 1 uppercase")]
        [DataRow("Abc123", "Try Again !There must be atleast 8 characters including atleast 1 uppercase")]
        public void PassMin8CharAnd1UpperCase(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.PassMin8CharAnd1UpperCase(userInput);
            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("a2345678", "Try Again !There must be atleast 8 characters including atleast 1 uppercase and 1 Numeric")]
        [DataRow("Abc123", "Try Again !There must be atleast 8 characters including atleast 1 uppercase and 1 Numeric")]
        public void UpperCase1AndNumeric1(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.UpperCase1AndNumeric1(userInput);
            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("Aa%@56", "Try Again !There must be atleast 8 characters including only 1 special char and atleast 1 uppercase and 1 Numeric")]
        [DataRow("@!@!A", "Try Again !There must be atleast 8 characters including only 1 special char and atleast 1 uppercase and 1 Numeric")]
        public void SpecialCharacter1(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.SpecialCharacter1(userInput);
            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("abc@yahoo.com", "Validated successfully!")]
        [DataRow("abc-100@yahoo.com", "Validated successfully!")]
        [DataRow("abc.100@yahoo.com", "Validated successfully!")]
        [DataRow("abc111@abc.com", "Validated successfully!")]
        [DataRow("abc-100@abc.net", "Validated successfully!")]
        [DataRow("abc.100@abc.com.au", "Validated successfully!")]
        [DataRow("abc@1.com", "Validated successfully!")]
        [DataRow("abc@gmail.com.com", "Validated successfully!")]
        [DataRow("abc+100@gmail.com", "Validated successfully!")]
        [DataRow("abc@.com.my", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc123@gmail.a", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc123@.com", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc123@.com.com", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow(".abc@abc.com", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc()*@gmail.com", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc@%*.com", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc..2002@gmail.com", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc.@gmail.com", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc@abc@gmail.com", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc@gmail.com.1a", "Entered Email ID is not in proper format .Please try again with something different.")]
        [DataRow("abc@gmail.com.aa.au", "Entered Email ID is not in proper format .Please try again with something different.")]
        public void EmailSample(string userInput, string expected)
        {
            try
            {
                string actualOutput = UserDetails.EmailId(userInput);
            }
            catch (CustomExceptionInvalidInput ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}