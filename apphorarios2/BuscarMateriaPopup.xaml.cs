using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class BuscarMateriaPopup : ContentPage
    {
        public BuscarMateriaPopup()
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