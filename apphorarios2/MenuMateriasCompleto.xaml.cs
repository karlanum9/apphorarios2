using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class MenuMateriasCompleto : ContentPage
    {
        public MenuMateriasCompleto()
        {
            InitializeComponent();
        }

        private void BtnAgregarMaterias_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AgregarMaterias());
        }

        private void BtnBorrarMaterias_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BorrarMaterias());
        }

        private void BtnEditarMaterias_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditarMaterias());
        }

        private void BtnConsultarMaterias_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConsultarMateriasCompleto());
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}