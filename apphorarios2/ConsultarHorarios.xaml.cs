using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConsultarHorarios : ContentPage
    {
        public ConsultarHorarios()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VerHorario());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}