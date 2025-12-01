using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarHorarios : ContentPage
    {
        public EditarHorarios()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla de selección
            Navigation.PushAsync(new EditarHorarioSeleccionar());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}