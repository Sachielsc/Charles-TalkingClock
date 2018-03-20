using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TalkingClockTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
			Assert.AreEqual("It's eleven eleven", TalkingClockConsole.TimeFormatTransfer('1', '1', '1', '1'));
		}
    }
}
