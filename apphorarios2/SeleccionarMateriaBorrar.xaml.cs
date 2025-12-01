using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class SeleccionarMateriaBorrar : ContentPage
    {
        public SeleccionarMateriaBorrar()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConfirmarBorrarMateria());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}