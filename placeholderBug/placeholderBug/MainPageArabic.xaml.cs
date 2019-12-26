using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace placeholderBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageArabic : ContentPage
    {
        public MainPageArabic()
        {
            InitializeComponent();
        }
        private void ChangeLangugeClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}