using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConsultarDocentesCompleto : ContentPage
    {
        public ConsultarDocentesCompleto()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}