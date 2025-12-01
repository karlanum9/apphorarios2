using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarHorariosDetalle : ContentPage
    {
        public EditarHorariosDetalle()
        {
            InitializeComponent();
        }

        private void BtnAulas_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Editar", "Funcionalidad para editar aulas", "OK");
        }

        private void BtnDias_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Editar", "Funcionalidad para editar días", "OK");
        }

        private void BtnHoras_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Editar", "Funcionalidad para editar horas", "OK");
        }

        private void BtnDocentes_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla de búsqueda
            Navigation.PushAsync(new BuscarDocentePopup());
        }

        private void BtnMaterias_Clicked(object sender, System.EventArgs e)
        {
            // Cambiado a la nueva pantalla de búsqueda
            Navigation.PushAsync(new BuscarMateriaPopup());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}