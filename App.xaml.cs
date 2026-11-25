using Ex_labs.Views;

namespace Ex_labs
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      MainPage = new LoginPage();
    }
  }
}
