using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class MenuMaterias : ContentPage
    {
        public MenuMaterias()
        {
            InitializeComponent();
        }

        private void BtnAgregarMaterias_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AgregarMaterias());
        }

        private void BtnBorrarMaterias_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla de selección
            Navigation.PushAsync(new SeleccionarMateriaBorrar());
        }

        private void BtnEditarMaterias_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla de selección
            Navigation.PushAsync(new SeleccionarMateriaEditar());
        }

        private void BtnConsultarMaterias_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla completa
            Navigation.PushAsync(new ConsultarMateriasCompleto());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}