using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TalkingClockTestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethodSuccessful()
		{
			Assert.AreEqual("It's twelve am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("00:00"));
			Assert.AreEqual("It's twelve oh one am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("00:01"));
			Assert.AreEqual("It's one am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("01:00"));
			Assert.AreEqual("It's one oh one am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("01:01"));
			Assert.AreEqual("It's one ten am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("01:10"));
			Assert.AreEqual("It's one eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("01:11"));
			Assert.AreEqual("It's eleven eleven am", TalkingClockConsole.InputValidationAndTimeFormatTransfer("11:11"));
			Assert.AreEqual("It's eight pm", TalkingClockConsole.InputValidationAndTimeFormatTransfer("20:00"));

		}

		[TestMethod]
		public void TestMethodFailed ()
		{
			Assert.AreEqual("Invalid time numbers!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("24:00"));
			Assert.AreEqual("Invalid time numbers!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("23:60"));
			Assert.AreEqual("Invalid time format!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("0:00"));
			Assert.AreEqual("Invalid time format!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("00:0"));
			Assert.AreEqual("Invalid time format!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("000:00"));
			Assert.AreEqual("Invalid time format!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("0000"));
			Assert.AreEqual("Invalid time format!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("24:00:00"));
			Assert.AreEqual("Invalid time format!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("23::00"));
			Assert.AreEqual("Invalid time format!", TalkingClockConsole.InputValidationAndTimeFormatTransfer("asd"));
		}
	}
}