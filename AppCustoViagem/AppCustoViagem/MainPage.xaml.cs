using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCustoViagem.View;

namespace AppCustoViagem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Calcular (object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalcularCusto());

        }
    }
}
