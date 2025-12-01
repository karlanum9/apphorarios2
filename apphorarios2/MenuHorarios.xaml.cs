using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class MenuHorarios : ContentPage
    {
        public MenuHorarios()
        {
            InitializeComponent();
        }

        private void BtnAsignarHorarios_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla completa
            Navigation.PushAsync(new AsignarHorariosCompleto());
        }

        private void BtnEditarHorarios_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditarHorarios());
        }

        private void BtnBorrarHorarios_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BorrarHorarios());
        }

        private void BtnConsultarHorarios_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConsultarHorarios());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}