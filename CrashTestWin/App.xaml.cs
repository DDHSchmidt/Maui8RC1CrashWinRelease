using TestClassLibraryOne;

namespace CrashTestWin
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//Just include it for the heck of it
			var testOne = new Class1();
			Console.WriteLine(testOne.ToString());

			MainPage = new AppShell();
		}
	}
}
