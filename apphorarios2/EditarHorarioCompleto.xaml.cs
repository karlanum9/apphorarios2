using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarHorarioCompleto : ContentPage
    {
        public EditarHorarioCompleto()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Éxito", "Horario editado correctamente", "OK");
            Navigation.PopAsync();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}