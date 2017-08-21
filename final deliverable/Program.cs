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
			string a, b;
			Console.WriteLine("Please enter a positive integer");
			a = Console.ReadLine();
			bool repeat = true; bool repeat2 = true;//to repeat while loop to catch for errors without throwing exception
			while (repeat)
			{
				repeat = false;
				try
				{
					int m = Int32.Parse(a);//have to hit enter twice if enter valid entry first time
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
			b = Console.ReadLine();
			while (repeat2)
			{
				repeat2 = false;
				try
				{
					int o = Int32.Parse(b);
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
			if (a.Length == b.Length)//to validate that input 2 has same digits as input 1
				repeat2 = false;
			else
				Console.WriteLine("Value does not match the number of digits from first, Please try again");
			repeat2 = true;

			Console.ReadLine();
			int newL, newK;
			newL = Int32.Parse(a);//assinged new values to converted string 
			newK = Int32.Parse(b);
			if (//unable to return values of transformation and transformation again
			//theory is that only sum of last set of digits and sum of first set of digits need to match, that's why I set it up this way

				Program.transformation(int)+Program.transformationAgain(int)== (newL % 10) + (newK % 10))
			{
				Console.WriteLine("True, Sum of digitis in same place add to the same sum");
			}
			else Console.WriteLine("False, sume of digits in same place do not add to the same sum");
		}
		public static int[] transformation(int x)
		{
			string a, numbers = x.ToString();
			int[] num = numbers.Split(';').Select(int.Parse).ToArray();
			int L = num.Length;
			int[] x1 = new int[L];
			for (int i = 0; i < L; i++)
			{
				a = num[i].ToString();
				x1[i] = Convert.ToInt32(a);
			}

			return x1;
		}
		public static int[] transformationAgain(int y)
		{
			string b, numbers = y.ToString();
			int[] num = numbers.Split(';').Select(int.Parse).ToArray();
			int K = num.Length;
			int[] y1 = new int[K];
			for (int i = 0; i < K; i++)
			{
				b = num[i].ToString();
				y1[i] = Convert.ToInt32(b);
			}

			return y1;
		}
	}
}
