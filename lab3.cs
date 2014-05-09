using System;

namespace Palindrome
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("PALINDROME");
			Console.WriteLine ("If you want to quit this process, press 'q'");

			do {
				Console.Write ("Enter a word: ");
				string word = Console.ReadLine ();

				if (word =="q")
					break;

				string origin_word = word;
				Palindrome (ref word, ref origin_word);

			} while(true);

			Console.WriteLine ("Bye");

		}

		public static string Palindrome(ref string word, ref string origin_word)
		{

			int n = word.Length;

			while ( n >= 0 ) {

				if ( n >= 2 && word [0] == word [n - 1]) {
					word = word.Substring (1, n - 2);
					return Palindrome (ref word, ref origin_word);
				} 
				else if (n == 1 || n == 0) {
					Console.WriteLine ("{0} is Palindrome", origin_word);
					break;
				}
				else {
					Console.WriteLine ("{0} is NOT Palindrome", origin_word);
					break;
				}
					
			}	return "";
		}
	}
}

