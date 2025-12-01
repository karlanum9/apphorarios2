using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class AgregarDocentes : ContentPage
    {
        public AgregarDocentes()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreDocente.Text))
            {
                DisplayAlert("Error", "Por favor ingresa el nombre del docente", "OK");
                return;
            }
            Navigation.PushAsync(new DocenteAgregado());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}