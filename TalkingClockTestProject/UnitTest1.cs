using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TalkingClockTestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethodSuccessful()
		{
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.TimeFormatTransfer('1', '1', '1', '1'));
			Assert.AreEqual("It's eleven ten am", TalkingClockConsole.TimeFormatTransfer('1', '1', '1', '0'));
			Assert.AreEqual("It's eleven twenty am", TalkingClockConsole.TimeFormatTransfer('1', '1', '2', '0'));
			Assert.AreEqual("It's eleven am", TalkingClockConsole.TimeFormatTransfer('1', '1', '0', '0'));
			Assert.AreEqual("It's twelve pm", TalkingClockConsole.TimeFormatTransfer('1', '2', '0', '0'));
			Assert.AreEqual("It's twelve am", TalkingClockConsole.TimeFormatTransfer('0', '0', '0', '0'));
		}

		[TestMethod]
		public void TestMethodFailed ()
		{
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.TimeFormatTransfer('1', '1', '1', '1'));
			Assert.AreEqual("It's eleven ten am", TalkingClockConsole.TimeFormatTransfer('1', '1', '1', '0'));
			Assert.AreEqual("It's eleven twenty am", TalkingClockConsole.TimeFormatTransfer('1', '1', '2', '0'));
			Assert.AreEqual("It's eleven am", TalkingClockConsole.TimeFormatTransfer('1', '1', '0', '0'));
			Assert.AreEqual("It's twelve pm", TalkingClockConsole.TimeFormatTransfer('1', '2', '0', '0'));
			Assert.AreEqual("Invalid time numbers!", TalkingClockConsole.TimeFormatTransfer('2', '5', '0', '0'));
		}
	}
}