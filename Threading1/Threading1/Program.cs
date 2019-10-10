using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading1
{
	class ThreadTest
	{
		private static bool _done;

		static void Main(string[] args)
		{
			//Separate thread
			new Thread(Go).Start();
			//Main thread;
			Go();
		}

		static void Go()
		{
			if (!_done)
			{
				_done = true;
				Console.WriteLine("Done");

				

				Console.ReadLine();
			}
		}
	}
}
