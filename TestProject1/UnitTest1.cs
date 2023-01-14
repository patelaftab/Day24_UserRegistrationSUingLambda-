using MsTestOnUserRegistration;
namespace MsTestOnUserRegistration
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow("Abc")]
        [DataRow("Abcd")]
        [DataRow("Ab")]
        [DataRow("abc")]
        public void FirstName(string userInput)
        {
            bool output = UserRegistration.FirstName(userInput);
            Assert.AreEqual(output, true);
        }
        [TestMethod]
        [DataRow("Abc")]    //pass
        [DataRow("Abcd")]   //pass
        [DataRow("Ab")]     //fail
        [DataRow("abc")]    //fail
        public void LastName(string userInput)
        {
            bool output = UserRegistration.LastName(userInput);      //UC2 LastName starts with cap and has min 3 char.
            Assert.AreEqual(output, true);
        }
        [TestMethod]
        [DataRow("abc@bl.com")]    //pass
        [DataRow("abc.xyz@bl.co.in")]   //pass
        [DataRow("abc123@gmail.a")]     //fail
        [DataRow("abc.@gmail.com")]    //fail
        public void EmailId(string userInput)
        {
            bool output = UserRegistration.EmailId(userInput);      //UC3 Email ID testing .
            Assert.AreEqual(output, true);
        }
        [TestMethod]
        [DataRow("91 8286828080")]    //pass
        [DataRow("91 9919292319")]   //pass
        [DataRow("91 0923252352")]     //fail
        [DataRow("919239323783 ")]    //fail
        public void MobileNumber(string userInput)
        {
            bool output = UserRegistration.MobileNumber(userInput);      //UC4 Mobile no format 91 8286828080
            Assert.AreEqual(output, true);
        }
        [TestMethod]
        [DataRow("Abc45678")]    //pass
        [DataRow("Abcd567890")]   //pass
        [DataRow("1234567")]     //fail
        [DataRow("Abc123")]    //fail
        public void PassMin8Char(string userInput)
        {
            bool output = UserRegistration.PassMin8Char(userInput);      //UC5 pass min 8 char..
            Assert.AreEqual(output, true);
        }
        [TestMethod]
        [DataRow("Abc45678")]    //pass
        [DataRow("Abcd567890")]   //pass
        [DataRow("a2345678")]     //fail
        [DataRow("Abc123")]    //fail
        public void PassMin8CharAnd1UpperCase(string userInput)
        {
            bool output = UserRegistration.PassMin8CharAnd1UpperCase(userInput);      //UC5 pass min 8 char and 1 uppercase
            Assert.AreEqual(output, true);
        }
        [TestMethod]
        [DataRow("Abc45678")]    //pass
        [DataRow("Abcd567890")]   //pass
        [DataRow("a2345678")]     //fail
        [DataRow("Abc123")]    //fail
        public void UpperCase1AndNumeric1(string userInput)
        {
            bool output = UserRegistration.UpperCase1AndNumeric1(userInput);      //UC7 min 8 char ,1 upper case ,i numeric.
            Assert.AreEqual(output, true);
        }
        [TestMethod]
        [DataRow("Abc@45678")]    //pass
        [DataRow("Abc#567890")]   //pass
        [DataRow("Aa%@5678")]
        [DataRow("@!@!Abc123")]
        public void SpecialCharacter1(string userInput)
        {
            bool output = UserRegistration.SpecialCharacter1(userInput);      //UC8 min 8 char , exactly 1 special char 
            Assert.AreEqual(output, true);
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
