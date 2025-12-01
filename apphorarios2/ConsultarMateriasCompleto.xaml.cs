using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConsultarMateriasCompleto : ContentPage
    {
        public ConsultarMateriasCompleto()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}