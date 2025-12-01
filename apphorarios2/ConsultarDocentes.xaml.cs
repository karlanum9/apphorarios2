using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConsultarDocentes : ContentPage
    {
        public ConsultarDocentes()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}