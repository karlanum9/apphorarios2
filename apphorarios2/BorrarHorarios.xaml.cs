using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class BorrarHorarios : ContentPage
    {
        public BorrarHorarios()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConfirmarBorrarHorario());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}