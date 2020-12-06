using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MetronomeV3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Metronome : ContentPage
    {
        public Metronome()
        {
            InitializeComponent();
        }

        private void MainSliderChanged(object sender, ValueChangedEventArgs e)
        {
            //MainSlider = new 
            sliderNumber.Text = ((int)Math.Round(MainSlider.Value)).ToString();
        }

        private void PlayMetronome(object sender, EventArgs e)
        {

        }
    }
}