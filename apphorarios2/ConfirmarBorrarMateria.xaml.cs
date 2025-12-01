using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConfirmarBorrarMateria : ContentPage
    {
        public ConfirmarBorrarMateria()
        {
            InitializeComponent();
        }

        private void BtnSi_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MateriaEliminada());
        }

        private void BtnNo_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}