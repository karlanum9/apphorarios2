using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConsultaAlumnoCompleto : ContentPage
    {
        public ConsultaAlumnoCompleto()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Clicked(object sender, System.EventArgs e)
        {
            FrameResultado.IsVisible = true;
            LblMaestro.Text = "Maestro: GLEN ADAN GALLEGOS CASTAÑEDA";
            LblMateria.Text = "Materia: IMPLEMENTA BASES DE DATOS NO RELACIONALES EN UN SISTEMA DE INFORMACION";
            LblGrupo.Text = "Grupo: 5AMPROG";
            LblDia.Text = "Día: Lunes";
            LblAula.Text = "Aula: CC1";
            LblHora.Text = "Hora: 7-8";
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}