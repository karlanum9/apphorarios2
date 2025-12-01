using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class MenuDocentes : ContentPage
    {
        public MenuDocentes()
        {
            InitializeComponent();
        }

        private void BtnAgregarDocentes_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AgregarDocentes());
        }

        private void BtnBorrarDocentes_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla de selección
            Navigation.PushAsync(new SeleccionarDocenteBorrar());
        }

        private void BtnEditarDocentes_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla de selección
            Navigation.PushAsync(new SeleccionarDocenteEditar());
        }

        private void BtnConsultarDocentes_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla completa
            Navigation.PushAsync(new ConsultarDocentesCompleto());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}