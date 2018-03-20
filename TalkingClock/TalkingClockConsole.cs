using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class TalkingClockConsole
{

	static void Main(string[] args)
	{
		// display the input rules
		string startMessage = "Type in your list of times (use ENTER to input multiple times):\nPress ENTER twice to finish input and check the result.\nPress 'exit' to quit the program";
		Console.WriteLine(startMessage);

		// ready for one or more input requests
		while (true)
		{
			// accept input data and proceed the conversion
			string Datainput()
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

			// proceed the first request
			Console.WriteLine(Datainput());

			// ready for the next request
			string endMessage = "Continue to type in more request or enter 'exit' to quit the program";
			Console.WriteLine(endMessage);
		}
	}

	public static string InputValidationAndTimeFormatTransfer(string timeInput)
	{
		string timeInWord = "";
		string pattern = @"^\d{2}:\d{2}$";
		string TimeFormatTransfer(char a, char b, char c, char d)
		{
			string hourWord = "";
			string minuteWord = "";
			string minuteWordFirstDigit = "";
			string minuteWordSecondDigit = "";
			string meridiem = "";
			string timeFormatTransferResult;
			int hourNum = (int)Char.GetNumericValue(a) * 10 + (int)Char.GetNumericValue(b);
			int minNum = (int)Char.GetNumericValue(c) * 10 + (int)Char.GetNumericValue(d);
			if (hourNum < 0 || hourNum >= 24 || minNum < 0 || minNum >= 60)
			{
				timeFormatTransferResult = "Invalid time numbers!";
			}
			else
			{
				switch (hourNum)
				{
					case 1:
						hourWord = "one";
						meridiem = "am";
						break;
					case 2:
						hourWord = "two";
						meridiem = "am";
						break;
					case 3:
						hourWord = "three";
						meridiem = "am";
						break;
					case 4:
						hourWord = "four";
						meridiem = "am";
						break;
					case 5:
						hourWord = "five";
						meridiem = "am";
						break;
					case 6:
						hourWord = "six";
						meridiem = "am";
						break;
					case 7:
						hourWord = "seven";
						meridiem = "am";
						break;
					case 8:
						hourWord = "eight";
						meridiem = "am";
						break;
					case 9:
						hourWord = "nine";
						meridiem = "am";
						break;
					case 10:
						hourWord = "ten";
						meridiem = "am";
						break;
					case 11:
						hourWord = "eleven";
						meridiem = "am";
						break;
					case 12:
						hourWord = "twelve";
						meridiem = "pm";
						break;
					case 13:
						hourWord = "one";
						meridiem = "pm";
						break;
					case 14:
						hourWord = "two";
						meridiem = "pm";
						break;
					case 15:
						hourWord = "three";
						meridiem = "pm";
						break;
					case 16:
						hourWord = "four";
						meridiem = "pm";
						break;
					case 17:
						hourWord = "five";
						meridiem = "pm";
						break;
					case 18:
						hourWord = "six";
						meridiem = "pm";
						break;
					case 19:
						hourWord = "seven";
						meridiem = "pm";
						break;
					case 20:
						hourWord = "eight";
						meridiem = "pm";
						break;
					case 21:
						hourWord = "nine";
						meridiem = "pm";
						break;
					case 22:
						hourWord = "ten";
						meridiem = "pm";
						break;
					case 23:
						hourWord = "eleven";
						meridiem = "pm";
						break;
					case 0:
						hourWord = "twelve";
						meridiem = "am";
						break;
				}
				if (minNum <= 19)
				{
					switch (minNum)
					{
						case 0:
							minuteWord = "";
							break;
						case 1:
							minuteWord = "oh one";
							break;
						case 2:
							minuteWord = "oh two";
							break;
						case 3:
							minuteWord = "oh three";
							break;
						case 4:
							minuteWord = "oh four";
							break;
						case 5:
							minuteWord = "oh five";
							break;
						case 6:
							minuteWord = "oh six";
							break;
						case 7:
							minuteWord = "oh seven";
							break;
						case 8:
							minuteWord = "oh eight";
							break;
						case 9:
							minuteWord = "oh nine";
							break;
						case 10:
							minuteWord = "ten";
							break;
						case 11:
							minuteWord = "eleven";
							break;
						case 12:
							minuteWord = "twelve";
							break;
						case 13:
							minuteWord = "thirteen";
							break;
						case 14:
							minuteWord = "fourteen";
							break;
						case 15:
							minuteWord = "fifteen";
							break;
						case 16:
							minuteWord = "sixteen";
							break;
						case 17:
							minuteWord = "seventeen";
							break;
						case 18:
							minuteWord = "eighteen";
							break;
						case 19:
							minuteWord = "nineteen";
							break;
					}
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
				timeInWord = "Invalid time format!";
			}
		}
		return timeInWord;
	}
}