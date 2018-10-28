using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
	class Program
	{
		static void Main(string[] args)
		{	
			Console.WriteLine("The current Date and Time is now: " + DateTime.Now);
			Console.WriteLine("Please pick a number between 1-12.");
			int userNum = Convert.ToInt32(Console.ReadLine());
			DateTime dateTime = DateTime.Now;
			Console.WriteLine("The current date and time plus the amount of hours you added is: {0} " , dateTime.AddHours(userNum));
			Console.ReadLine();

		}
	}
}
