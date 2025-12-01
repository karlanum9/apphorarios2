using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarDocentesGuardado : ContentPage
    {
        public EditarDocentesGuardado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}