using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConfiguracionSistema : ContentPage
    {
        public ConfiguracionSistema()
        {
            InitializeComponent();
        }

        private void BtnGuardarConfig_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Éxito", "Configuración guardada correctamente", "OK");
            Navigation.PopAsync();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}