using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class VerHorario : ContentPage
    {
        public VerHorario()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}