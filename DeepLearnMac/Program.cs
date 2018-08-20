using System;
using Gtk;

namespace DeepLearnMac
{
	static class MainClass
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			try
			{
				bool owned;

				var hMutex = new System.Threading.Mutex(true, "DeepLearnMac (BETA)", out owned);

				if (owned)
				{
					Application.Init();

					MainWindow win = new MainWindow();
					win.Show();

					Application.Run();
				}
				else
				{
					Console.WriteLine("Application is already running");

					return;
				}

				GC.KeepAlive(hMutex);

			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: {0}", ex.Message);
			}

			return;
		}
	}
}
