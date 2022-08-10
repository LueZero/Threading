using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Foo._1
{
    public class Foo
    {
        public int pauseTime = 1000;
        public object LockA = new Object();
		public object LockB = new Object();

		public Foo()
		{
			try
			{
				Monitor.Enter(LockA);
				Monitor.Enter(LockB);
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
				Monitor.Exit(LockA);
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
				Monitor.Enter(LockA);
				Monitor.Exit(LockA);
				Console.WriteLine("Started Executing 2");
				Thread.Sleep(pauseTime);
				Console.WriteLine("Finished Executing 2");
				Monitor.Exit(LockB);
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
				Monitor.Enter(LockB);
				Monitor.Exit(LockB);
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
