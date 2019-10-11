using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
	class Program
	{
		static void Main(string[] args)
		{
			BubbleSort();
		}

		public static void BubbleSort()
		{
			int[] a = { 3, 0, 2, 5, -1, 4, 1 }; 
			int t; 
			Console.WriteLine("Original array :");
			foreach (int aa in a)                       
				Console.Write(aa + " ");                     
			//
			for (int p = 0; p <= a.Length - 2; p++)
			{
				for (int i = 0; i <= a.Length - (2 + p); i++)
				{
					//Is the value of this position in the 'a' array greater than the value of the next position of 'a' array?
					//If yes - set t to the greater.  Set the greater to the value of the current position.  Set the current position's value to the greater value.
					//If no - iterate to the next position in a. 
					if (a[i] > a[i + 1])
					{
						t = a[i + 1];
						a[i + 1] = a[i];
						a[i] = t;
					}
				} 
			}
			Console.WriteLine("\n"+"Sorted array :");
			foreach (int aa in a)                       
				Console.Write(aa + " ");
			Console.Write("\n");
			Console.ReadLine();
		}
	}
}
