using ICT13580575EndB.Helper;
using Xamarin.Forms;

namespace ICT13580575EndB
{
    public partial class App : Application
    {
		public static DbHelper DbHelper { get; set; }

		public App()
		{
			InitializeComponent();
		}

		public App(string dbPath)
		{
			InitializeComponent();

			DbHelper = new DbHelper(dbPath);

			MainPage = new NavigationPage(new MainPage());

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
