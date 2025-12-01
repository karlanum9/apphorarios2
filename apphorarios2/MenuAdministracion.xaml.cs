using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class MenuAdministracion : ContentPage
    {
        public MenuAdministracion()
        {
            InitializeComponent();
        }

        private void BtnHorarios_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuHorarios());
        }

        private void BtnGrupos_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuGrupos());
        }

        private void BtnDocentes_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuDocentes());
        }

        private void BtnMaterias_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla completa de materias
            Navigation.PushAsync(new MenuMateriasCompleto());
        }

        // AGREGAR NUEVOS BOTONES
        private void BtnConfiguracion_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConfiguracionSistema());
        }

        private void BtnAcercaDe_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AcercaDe());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}