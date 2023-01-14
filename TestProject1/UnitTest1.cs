using 
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
        [DataRow("abc@yahoo.com")]    //pass
        [DataRow("abc-100@yahoo.com")]   //pass ..
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        [DataRow("abc", "abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void EmailSample(string userInput)
        {
            bool output = UserDetails.EmailSample(userInput);      //UC9 Email Samples .
            Assert.AreEqual(output, true);
        }
    }
}
