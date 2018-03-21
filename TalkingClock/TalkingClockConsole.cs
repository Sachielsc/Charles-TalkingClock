using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TalkingClock;

public class TalkingClockConsole
{

	static void Main(string[] args)
	{
		// display the input rules
		string startMessage = "Type in your list of times (use ENTER to input multiple times):\nPress ENTER twice to finish input and check the result.\nPress 'exit' to quit the program";
		Console.WriteLine(startMessage);

		// accept input data and proceed the conversion
		string Run()
		{
			string timeInput = " ";
			List<string> results = new List<string> { };
			while (!string.IsNullOrEmpty(timeInput))
			{
				timeInput = Console.ReadLine();

				if (timeInput == "exit")
				{
					Environment.Exit(0);
				}

				else results.Add(InputValidationAndTimeFormatTransfer(timeInput));
			}
			foreach (string result in results)
			{
				timeInput = timeInput + result + "\n";
			}
			return timeInput;
		}

		// ready for one or more input requests
		while (true)
		{
			// proceed the first request
			Console.WriteLine(Run());

			// ready for the next request
			string endMessage = "Continue to type in more request or enter 'exit' to quit the program";
			Console.WriteLine(endMessage);
		}
	}

	public static string InputValidationAndTimeFormatTransfer(string timeInput)
	{
		string timeInWord = "";
		string pattern = @"^\d{2}:\d{2}$";
		string errorMessageInvalidFormat = "Invalid time format!";
		string errorMessageInvalidNumber = "Invalid time numbers!";
		string TimeFormatTransfer(char a, char b, char c, char d)
		{
			string hourWord = "";
			string minuteWord = "";
			string minuteWordFirstDigit = "";
			string minuteWordSecondDigit = "";
			string meridiem = "";
			string meridiemAM = "am";
			string meridiemPM = "pm";
			string timeFormatTransferResult;
			List<HourNum> hourNumbers = new List<HourNum>
				{
					new HourNum(){ Number = 0, Word = "twelve", Meridiem = meridiemAM},
					new HourNum(){ Number = 1, Word = "one", Meridiem = meridiemAM},
					new HourNum(){ Number = 2, Word = "two", Meridiem = meridiemAM},
					new HourNum(){ Number = 3, Word = "three", Meridiem = meridiemAM},
					new HourNum(){ Number = 4, Word = "four", Meridiem = meridiemAM},
					new HourNum(){ Number = 5, Word = "five", Meridiem = meridiemAM},
					new HourNum(){ Number = 6, Word = "six", Meridiem = meridiemAM},
					new HourNum(){ Number = 7, Word = "seven", Meridiem = meridiemAM},
					new HourNum(){ Number = 8, Word = "eight", Meridiem = meridiemAM},
					new HourNum(){ Number = 9, Word = "nine", Meridiem = meridiemAM},
					new HourNum(){ Number = 10, Word = "ten", Meridiem = meridiemAM},
					new HourNum(){ Number = 11, Word = "eleven", Meridiem = meridiemAM},
					new HourNum(){ Number = 12, Word = "twelve", Meridiem = meridiemPM},
					new HourNum(){ Number = 13, Word = "one", Meridiem = meridiemPM},
					new HourNum(){ Number = 14, Word = "two", Meridiem = meridiemPM},
					new HourNum(){ Number = 15, Word = "three", Meridiem = meridiemPM},
					new HourNum(){ Number = 16, Word = "four", Meridiem = meridiemPM},
					new HourNum(){ Number = 17, Word = "five", Meridiem = meridiemPM},
					new HourNum(){ Number = 18, Word = "six", Meridiem = meridiemPM},
					new HourNum(){ Number = 19, Word = "seven", Meridiem = meridiemPM},
					new HourNum(){ Number = 20, Word = "eight", Meridiem = meridiemPM},
					new HourNum(){ Number = 21, Word = "nine", Meridiem = meridiemPM},
					new HourNum(){ Number = 22, Word = "ten", Meridiem = meridiemPM},
					new HourNum(){ Number = 23, Word = "eleven", Meridiem = meridiemPM},
				};
			List<MinuteNum> minuteNumbers = new List<MinuteNum>
					{
						new MinuteNum(){ Number = 0, Word = ""},
						new MinuteNum(){ Number = 1, Word = "oh one"},
						new MinuteNum(){ Number = 2, Word = "oh two"},
						new MinuteNum(){ Number = 3, Word = "oh three"},
						new MinuteNum(){ Number = 4, Word = "oh four"},
						new MinuteNum(){ Number = 5, Word = "oh five"},
						new MinuteNum(){ Number = 6, Word = "oh six"},
						new MinuteNum(){ Number = 7, Word = "oh seven"},
						new MinuteNum(){ Number = 8, Word = "oh eight"},
						new MinuteNum(){ Number = 9, Word = "oh nine"},
						new MinuteNum(){ Number = 10, Word = "ten"},
						new MinuteNum(){ Number = 11, Word = "eleven"},
						new MinuteNum(){ Number = 12, Word = "twelve"},
						new MinuteNum(){ Number = 13, Word = "thirteen"},
						new MinuteNum(){ Number = 14, Word = "fourteen"},
						new MinuteNum(){ Number = 15, Word = "fifteen"},
						new MinuteNum(){ Number = 16, Word = "sixteen"},
						new MinuteNum(){ Number = 17, Word = "seventeen"},
						new MinuteNum(){ Number = 18, Word = "eighteen"},
						new MinuteNum(){ Number = 19, Word = "nineteen"},
					};
			int hourNum = (int)Char.GetNumericValue(a) * 10 + (int)Char.GetNumericValue(b);
			int minNum = (int)Char.GetNumericValue(c) * 10 + (int)Char.GetNumericValue(d);
			if (hourNum < 0 || hourNum >= 24 || minNum < 0 || minNum >= 60)
			{
				timeFormatTransferResult = errorMessageInvalidNumber;
			}
			else
			{
				foreach (HourNum hourNumber in hourNumbers)
					if (hourNum == hourNumber.Number)
					{
						hourWord = hourNumber.Word;
						meridiem = hourNumber.Meridiem;
					};

				if (minNum <= 19)
				{
					foreach (MinuteNum minuteNumber in minuteNumbers)
						if (minNum == minuteNumber.Number)
						{
							minuteWord = minuteNumber.Word;
						};
				}
				else
				{
					switch ((int)Char.GetNumericValue(c))
					{
						case 2:
							minuteWordFirstDigit = "twenty";
							break;
						case 3:
							minuteWordFirstDigit = "thirty";
							break;
						case 4:
							minuteWordFirstDigit = "forty";
							break;
						case 5:
							minuteWordFirstDigit = "fifty";
							break;
					};
					switch ((int)Char.GetNumericValue(d))
					{
						case 0:
							minuteWordSecondDigit = "";
							break;
						case 1:
							minuteWordSecondDigit = "one";
							break;
						case 2:
							minuteWordSecondDigit = "two";
							break;
						case 3:
							minuteWordSecondDigit = "three";
							break;
						case 4:
							minuteWordSecondDigit = "four";
							break;
						case 5:
							minuteWordSecondDigit = "five";
							break;
						case 6:
							minuteWordSecondDigit = "six";
							break;
						case 7:
							minuteWordSecondDigit = "seven";
							break;
						case 8:
							minuteWordSecondDigit = "eight";
							break;
						case 9:
							minuteWordSecondDigit = "nine";
							break;
					};
					minuteWord = (minuteWordFirstDigit + " " + minuteWordSecondDigit).Trim();
				}
				timeFormatTransferResult = ("It's " + hourWord + " " + minuteWord).Trim() + " " + meridiem;
			}

			return timeFormatTransferResult;
		}

		if (Regex.IsMatch(timeInput, pattern))
		{
			char[] separated;
			separated = timeInput.ToCharArray();
			timeInWord = TimeFormatTransfer(separated[0], separated[1], separated[3], separated[4]);
		}
		else
		{
			if (string.IsNullOrEmpty(timeInput))
			{
				timeInWord = "";
			}
			else
			{
				timeInWord = errorMessageInvalidFormat;
			}
		}
		return timeInWord;
	}
}