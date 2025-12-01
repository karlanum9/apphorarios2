using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class GrupoEliminado : ContentPage
    {
        public GrupoEliminado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}