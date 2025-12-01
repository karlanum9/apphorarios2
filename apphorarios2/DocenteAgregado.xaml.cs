using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class DocenteAgregado : ContentPage
    {
        public DocenteAgregado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}