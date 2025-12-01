using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class AsignarHorariosCompleto : ContentPage
    {
        public AsignarHorariosCompleto()
        {
            InitializeComponent();
        }

        private void BtnCrear_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Éxito", "Horario creado correctamente", "OK");
            Navigation.PopAsync();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}