using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConsultarGrupos : ContentPage
    {
        public ConsultarGrupos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}