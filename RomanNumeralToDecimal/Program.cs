using System;
using System.Collections.Generic;

/* Partial solution to a recent Job Interview question i answered. 
 * Currently doesn't function correctly when dealing with numbers 
 * such as IV, this solution will output 6 rather than 4.
 * 
 * Solution by Ryan Moss, 17th November 2016 */

class Program
{
	
	static void Main(string[] args)
	{
		Dictionary<char, int> romans = new Dictionary<char, int>();
		romans.Add('I', 1);
		romans.Add('V', 5);
		romans.Add('X', 10);
		romans.Add('L', 50);
		romans.Add('C', 100);
		romans.Add('D', 500);
		romans.Add('M', 1000);

		Console.WriteLine("Roman Numeral to Decimal Converter");

		Console.WriteLine("X: {0}", RomanToDecimal("XII", romans));

		Console.ReadLine();
	}

	public static float RomanToDecimal(string roman, Dictionary<char, int> numerals)
	{
		char[] characters = roman.ToCharArray();
		float decValue = 0;
		for (int i = 0; i < characters.Length; i++)
		{
			decValue += numerals[characters[i]];
		}

		return decValue;

	}



}
