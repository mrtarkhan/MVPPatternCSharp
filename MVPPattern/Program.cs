using System;

namespace MVPPattern
{
	class Program : IView
	{

		IPresenter presenter;

		public Program ()
		{
			presenter = new Presenter();
		}

		static void Main (string[] args)
		{

			Program program = new Program();
			program.ShowData("Mohammadreza Tarkhan");
			var name = string.Empty;
			Console.WriteLine("enter a name: ");
			while (name != "exit") {
				name = Console.ReadLine();
				program.presenter.ChangeName(name);
			}

			Console.WriteLine("press any key to exit...");
			Console.ReadLine();


		}

		public void ShowData (string name)
		{
			Console.WriteLine("My name is: {0} ", name);
		}

	}
}
