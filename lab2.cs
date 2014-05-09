using System;

namespace Drawing
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Draw(3, 1, "*");
			Draw(4, 2, "#");
			Draw(8, 4, "%");

		}

		public static void Draw(int a, int b, string c)
		{
			for (int outer = 0; outer <= a; outer++){
				for (int inner = 0; inner < outer * b; inner++) {
					Console.Write (c);
				}
				Console.WriteLine ();
			}
		}
	}
}
