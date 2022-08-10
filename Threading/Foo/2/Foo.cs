using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Foo._2
{
    public class Foo
    {
        public int pauseTime = 1000;
        public Semaphore sem1;
        public Semaphore sem2;

		public Foo()
		{
			try
			{
				sem1 = new Semaphore(1, 1);
				sem2 = new Semaphore(1, 1);

				sem1.WaitOne();
				sem2.WaitOne();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void First()
		{
			try
			{
				Console.WriteLine("Started Executing 1");
				Thread.Sleep(pauseTime);
				Console.WriteLine("Finished Executing 1");
				sem1.Release();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void Second()
		{
			try
			{
				sem1.WaitOne();
				sem1.Release();
				Console.WriteLine("Started Executing 2");
				Thread.Sleep(pauseTime);
				Console.WriteLine("Finished Executing 2");
				sem2.Release();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void Third()
		{
			try
			{
				sem2.WaitOne();
				sem2.Release();
				Console.WriteLine("Started Executing 3");
				Thread.Sleep(pauseTime);
				Console.WriteLine("Finished Executing 3");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
