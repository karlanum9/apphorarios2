using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarMateriasDetalle : ContentPage
    {
        public EditarMateriasDetalle()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditarMateriasGuardado());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}