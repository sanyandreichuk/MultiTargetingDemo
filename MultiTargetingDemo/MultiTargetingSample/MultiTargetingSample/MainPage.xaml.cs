using MultiTargetingDemo.Core;
using Xamarin.Forms;

namespace MultiTargetingSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            AppName.Text = AppProperties.AppName;
        }
    }
}
