using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
	class ThreadTest
	{
		private static bool _done;

		static void Main(string[] args)
		{
			Thread t = new Thread(Go);
			t.Start();
			t.Join();
			Console.WriteLine("Thread t has ended!");
			Console.ReadLine();
		}

		static void Go()
		{
			for (int i = 0; i < 1000; i++)
			{
				Console.WriteLine("y");
			}

			Console.ReadLine();
		}
	}
}
