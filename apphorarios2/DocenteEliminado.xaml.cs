using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class DocenteEliminado : ContentPage
    {
        public DocenteEliminado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}