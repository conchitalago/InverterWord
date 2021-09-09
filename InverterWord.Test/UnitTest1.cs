using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InverterWord.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWordInverter()
        {
            string word = InverterModel.InvertWord("ZOQUETE");
            StringAssert.Equals("ETEUQOZ",word);
        }
        [TestMethod]
        public void TestWordInverterMock()
        {
            string word = InverterModel.InvertWord("ZOQUETE");
            StringAssert.Equals("ETEUQOk",word);
        }
        [TestMethod]
        public void TestCountCharWord()
        {
            string word = InverterModel.InvertWord("ZOQUETE");
            //No se como se hace en visual no encuentro en assertString
        }
    }
}
