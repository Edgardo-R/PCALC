using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCALC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageOne : ContentPage
    {
        public PageOne()
        {
            InitializeComponent();
        }

        private async void btnSuma_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Resultado: ", Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text)), "Aceptar");
        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Resultado: ", Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text)), "Aceptar");
        }

        private async void btnMult_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Resultado: ", Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text)), "Aceptar");
        }

        private async void btnDiv_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Resultado: ", Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text)), "Aceptar");
        }
    }
}