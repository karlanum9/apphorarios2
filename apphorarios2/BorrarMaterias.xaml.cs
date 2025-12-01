using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class BorrarMaterias : ContentPage
    {
        public BorrarMaterias()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConfirmarBorrarMateria());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}