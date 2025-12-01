using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class HorarioEliminado : ContentPage
    {
        public HorarioEliminado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            // Regresar al menú principal de horarios
            Navigation.PopToRootAsync();
        }
    }
}