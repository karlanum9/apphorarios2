using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class BorrarGrupos : ContentPage
    {
        public BorrarGrupos()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConfirmarBorrarGrupo());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}