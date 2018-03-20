using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TalkingClockTestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethodSuccessful()
		{
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("00:00"));
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("00:01"));
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("01:00"));
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("01:01"));
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("01:10"));
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("01:11"));
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("11:11"));
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("10:00"));

		}

		[TestMethod]
		public void TestMethodFailed ()
		{
			Assert.AreEqual("Invalid time numbers!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("25:00"));
		}
	}
}