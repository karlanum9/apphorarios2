using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarMaterias : ContentPage
    {
        public EditarMaterias()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditarMateriasDetalle());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}