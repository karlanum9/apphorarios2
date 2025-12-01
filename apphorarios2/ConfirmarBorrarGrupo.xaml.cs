using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConfirmarBorrarGrupo : ContentPage
    {
        public ConfirmarBorrarGrupo()
        {
            InitializeComponent();
        }

        private void BtnSi_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GrupoEliminado());
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