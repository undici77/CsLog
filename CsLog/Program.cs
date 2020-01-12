using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

class App
{
	[DllImport("winmm.dll", EntryPoint = "timeBeginPeriod", SetLastError = true)]
	private static extern uint TimeBeginPeriod(uint uMilliseconds);

	static void Main(string[] args)
	{
		TestThread test_thread;
		int        id;

		// Set process timers granularity to 1ms
		TimeBeginPeriod(1);

		// Initialize log
		Log.Instance.Init("./", "log", Append);

		// Set log level to init value (INFO_LEVEL + DEBUG_LEVEL + CATCH_LEVEL)
		Log.Instance.Level = 7;

		// Enable log to file
		Log.Instance.ToFile = true;

		// Write some init log
		Log.Instance.Info("Main: started");
		Log.Instance.Debug("Main: Wait 100 ms and start asynch test thread");

		Thread.Sleep(100);

		// Create test thread that will write some async log
		test_thread = new TestThread();

		// Write some debug log
		for (id = 0; id < 20; id++)
		{
			Log.Instance.Debug("Main: write some debug [" + id + "]");
			Thread.Sleep(10);
		}

		Log.Instance.Info("Main: let's try to log a catch exception");
		try
		{
			Log.Instance.Info("Main: creating a null string and trying to access to it");

			string str = null;
			str = str.Substring(0);

			Log.Instance.Error("Main: if you see this line in log, something gone wrong");
		}
		catch (Exception ex)
		{
			Log.Instance.Catch("Main: " + ex.Message);
		}

		// Wait test thread end
		test_thread.Join();

		// Let's disable now log to file
		Log.Instance.Info("Main: Let's disable now log to file");

		// ToFile is ASYNCRONOUS!!
		Thread.Sleep(10);
		Log.Instance.ToFile = false;
		Thread.Sleep(10);

		Log.Instance.Error("Main: this message will not appear in log file");
		Thread.Sleep(10);

		// Let's enable now log to file
		Log.Instance.ToFile = true;
		// ToFile is ASYNCRONOUS!!
		Thread.Sleep(10);
		Log.Instance.Info("Main: Let's enable again log to file");

		// ToFile is ASYNCRONOUS!!
		Thread.Sleep(10);
		
		Log.Instance.Info("Main: end");

		// Close log
		Log.Instance.End();

		Console.WriteLine("... Press any key to close window ...");
		Console.ReadKey();
	}

	static void Append(string log)
	{
		// Write log to UI
		// In WinForm remember to use BeginInvoke
		Console.WriteLine(log);
	}
}

class TestThread
{
	private Thread _Thread;

	public TestThread()
	{
		_Thread = new Thread(Run);

		Log.Instance.Info("TestThread: ready to start");

		_Thread.Start();
	}

	public void Join()
	{
		_Thread.Join();
	}

	private void Run()
	{
		int id;

		// Write init log
		Log.Instance.Info("TestThread: started");

		for (id = 0; id < 30; id++)
		{
			// Write some debug log
			Log.Instance.Debug("TestThread: write some debug [" + id + "]");
			Thread.Sleep(10);
		}

		// Write end log
		Log.Instance.Info("TestThread: end");
	}
}
