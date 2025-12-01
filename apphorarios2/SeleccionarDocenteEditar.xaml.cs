using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class SeleccionarDocenteEditar : ContentPage
    {
        public SeleccionarDocenteEditar()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditarDocentesDetalle());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}