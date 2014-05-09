using System;

namespace Numbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("**********************************");
			Console.WriteLine ("******** Lottery Numbers *********");
			Console.WriteLine ("**********************************");


			string name = EnterName ();
			int [] numbers = new int[6] { 0, 0, 0, 0, 0, 0 };
			ExtractingNumbers (ref numbers);
			ShowResult (ref name, ref numbers);
					
		}

		public static string EnterName ()
		{
			Console.Write ("Enter your name: ");
			return Console.ReadLine ();

		}

		public static int[] ExtractingNumbers (ref int [] numbers)
		{
			Random random = new Random ();
		
			int index = 0;
			do {		
				bool found = false;
				int randomNumber = random.Next (1, 46);
				for (int loop = 0; loop < index; loop++) {
					if (numbers [loop] == randomNumber) {
						found = true;
						break;
					}
				}
				if (!found) {
					numbers [index] = randomNumber;
					index++;
				}
			} while(index < numbers.Length);
			return numbers;
		}

		public static string ShowResult(ref string name, ref int[] numbers)
			{
			Console.Write ("Name: {0} Numbers : [", name);
			foreach(int number in numbers)
			{
				Console.Write ("{0} ", number);
			}
			Console.WriteLine ("]");
			return name;
		}
	}
}
