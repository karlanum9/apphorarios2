using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class EditarMateriasGuardado : ContentPage
    {
        public EditarMateriasGuardado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}