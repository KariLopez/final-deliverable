using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_deliverable
{
	class Program
	{
		static void Main(string[] args)
		{
			string i, j;
			Console.WriteLine("Please enter a positive integer");
			i = Console.ReadLine();
			bool repeat = true; bool repeat2 = true;//to repeat while loop to catch for errors without throwing exception
			while (repeat)
			{
				repeat = false;
				try
				{
					int m = Int32.Parse(i);//have to hit enter twice if enter valid entry first time
					uint p = (uint)(m);//to validate input is positive
				}
				catch (FormatException)
				{
					Console.WriteLine("Input is not a valid string of digits, Please try again");
					repeat = true;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Number is too long, Please try again");
					repeat = true;
				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("Value is zero, Please try again");
					repeat = true;
				}
				finally
				{
					Console.ReadLine();
					repeat = false;
				}
			}
			Console.WriteLine("Please enter a 2nd positive integer with the same number of digits as the first");
			j = Console.ReadLine();
			while (repeat2)
			{
				repeat2 = false;
				try
				{
					int o = Int32.Parse(j);
					uint q = (uint)(o);
				}
				catch (FormatException)
				{
					Console.WriteLine("Input is not a valid string of digits, Please try again");
					repeat2 = true;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Input is too long, Please try again");
					repeat2 = true;
				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("Input is zero, Please try again");
					repeat2 = true;
				}
				finally
				{
					Console.ReadLine();
					repeat2 = false;
				}
			}
			if (i.Length == j.Length)//to validate that input 2 has same digits as input 1
				repeat2 = false;
			else
				Console.WriteLine("Value does not match the number of digits from first, Please try again");
			repeat2 = true;
			Console.ReadLine();
			int l, k;
			l = Int32.Parse(i);//assinged new values to converted string 
			k = Int32.Parse(j);
			if (((k % 10) + (l % 10)) == ((k /= 10) + (l /= 10)))
				Console.WriteLine("True, values are equal");
			else
				Console.WriteLine("False, values are not equal");
		}
	}
}
