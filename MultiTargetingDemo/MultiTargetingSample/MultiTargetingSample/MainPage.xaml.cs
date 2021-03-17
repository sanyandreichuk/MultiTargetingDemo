using MultiTargetingDemo.Core;
using Xamarin.Forms;

namespace MultiTargetingSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GreetingLabel.Text = AppProperties.AppName;
        }
    }
}
