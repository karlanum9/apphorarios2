using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class AgregarMaterias : ContentPage
    {
        public AgregarMaterias()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreMateria.Text))
            {
                DisplayAlert("Error", "Por favor ingresa el nombre de la materia", "OK");
                return;
            }
            Navigation.PushAsync(new MateriaAgregada());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}