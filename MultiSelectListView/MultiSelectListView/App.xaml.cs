
using Xamarin.Forms;

namespace MultiSelectListView
{
	public partial class App : Application
	{

		public static NavigationPage NavPage = new NavigationPage(new MainPage());

		public App()
		{
			InitializeComponent();

			MainPage = NavPage;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
