using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class AcercaDe : ContentPage
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}