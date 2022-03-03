using System;

namespace Adding_Numbers_Till_Zero
{
    class Program
    {
		static int digSum(int n)
		{
			int sum = 0;

			// Loop to do sum while
			// sum is not less than
			// or equal to 9
			while (n > 0 || sum > 9)
			{
				if (n == 0)
				{
					n = sum;
					sum = 0;
				}
				sum += n % 10;
				n /= 10;
			}
			return sum;
		}

		// Driver code
		public static void Main()
		{
			Console.WriteLine("Enter a number");
			int n = int.Parse(Console.ReadLine());
			Console.Write(digSum(n));
			Console.ReadLine();
		}
	}
}
