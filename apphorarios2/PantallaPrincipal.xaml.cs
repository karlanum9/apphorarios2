using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class PantallaPrincipal : ContentPage
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAlumno_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla completa
            Navigation.PushAsync(new ConsultaAlumnoCompleto());
        }

        private void BtnDocente_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla completa
            Navigation.PushAsync(new ConsultaDocenteCompleto());
        }

        private void BtnAdministracion_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AdministracionLogin());
        }
    }
}