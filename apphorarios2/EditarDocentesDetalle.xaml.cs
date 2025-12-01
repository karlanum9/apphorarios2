using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarDocentesDetalle : ContentPage
    {
        public EditarDocentesDetalle()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditarDocentesGuardado());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}