using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class GrupoAgregado : ContentPage
    {
        public GrupoAgregado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}