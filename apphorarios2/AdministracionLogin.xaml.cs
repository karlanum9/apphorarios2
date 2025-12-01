using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class AdministracionLogin : ContentPage
    {
        public AdministracionLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Clicked(object sender, System.EventArgs e)
        {
            // Aquí puedes agregar validación de contraseña
            Navigation.PushAsync(new MenuAdministracion());
        }
    }
}