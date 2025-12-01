using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class MenuGrupos : ContentPage
    {
        public MenuGrupos()
        {
            InitializeComponent();
        }

        private void BtnAgregarGrupos_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AgregarGrupos());
        }

        private void BtnBorrarGrupos_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BorrarGrupos());
        }

        private void BtnConsultarGrupos_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConsultarGrupos());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}