using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MetronomeV3
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            //MainPage = new NavigationPage(new YourPageName()) { BarBackgroundColor = Color.FromHex("#0E547C"), BarTextColor = Color.White };
            InitializeComponent();
            Detail = new NavigationPage(new Metronome());

            IsPresented = false;

        }

        private void ReturnMetronome(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Metronome());

            IsPresented = false;
        }

        private void ReturnNotes(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Notes());
            IsPresented = false;
        }
    }
}
