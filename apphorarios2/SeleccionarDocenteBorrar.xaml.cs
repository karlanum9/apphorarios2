using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class SeleccionarDocenteBorrar : ContentPage
    {
        public SeleccionarDocenteBorrar()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConfirmarBorrarDocente());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}