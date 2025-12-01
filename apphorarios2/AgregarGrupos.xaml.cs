using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class AgregarGrupos : ContentPage
    {
        public AgregarGrupos()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreGrupo.Text))
            {
                DisplayAlert("Error", "Por favor ingresa un nombre de grupo", "OK");
                return;
            }
            Navigation.PushAsync(new GrupoAgregado());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}