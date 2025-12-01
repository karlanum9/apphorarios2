using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarHorarioSeleccionar : ContentPage
    {
        public EditarHorarioSeleccionar()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditarHorarioCompleto());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}