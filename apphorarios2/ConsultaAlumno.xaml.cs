using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class ConsultaAlumno : ContentPage
    {
        public ConsultaAlumno()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Clicked(object sender, System.EventArgs e)
        {
            FrameResultado.IsVisible = true;
            LblAlumno.Text = "Alumno: [Nombre del alumno]";
            LblGrupo.Text = "Grupo: SAMPROG";
            LblAula.Text = "Aula: CCI";
            LblHora.Text = "Hora: 9am - 10pm";
            LblMaestro.Text = "Maestro: Glen Adam Gallegos";
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}