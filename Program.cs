using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Program
	{
		static void Main()

		{
			do
			{
				int S, C, N;

				Console.WriteLine("Learn Your Squares & Cubes!");
				Console.WriteLine("Please Enter an Integar: ");

				N = int.Parse(Console.ReadLine());
				S = N * N;
				C = N * N * N;

				Console.WriteLine(S + " Is your number squared.");
				Console.WriteLine(C + " Is your number cubed.");
			}
			while (Continue() == true); 

		}
		public static Boolean Continue()
		{
			Boolean run;
			Console.WriteLine("Continue: y/n?");
			string answer = Console.ReadLine();

			if ((answer == "Y") || (answer == "y"))
			{
				run = true;
			}
			else if ((answer == "N") || (answer == "n"))
			{
				run = false;
				Console.WriteLine("Later.");
			}
			else
			{
				Console.WriteLine("Yadda Yadda");
				run = Continue();
			}
			return run;
		}
	}

}
