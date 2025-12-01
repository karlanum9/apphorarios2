using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class BuscarDocentePopup : ContentPage
    {
        public BuscarDocentePopup()
        {
            InitializeComponent();
        }

        private void BtnSeleccionar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void BtnCancelar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}