using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConsultaDocente : ContentPage
    {
        public ConsultaDocente()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Clicked(object sender, System.EventArgs e)
        {
            FrameResultado.IsVisible = true;
            LblMaestro.Text = "Maestro: GLEN ADAN GALLEGOS CASTAÑEDA";
            LblGrupo.Text = "Grupo: SAMPROG";
            LblHora.Text = "Hora: 9am - 10pm";
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}