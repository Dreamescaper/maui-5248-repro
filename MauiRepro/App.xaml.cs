using Application = Microsoft.Maui.Controls.Application;

namespace MauiRepro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
