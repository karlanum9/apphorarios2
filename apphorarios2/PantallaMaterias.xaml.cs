using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class PantallaMaterias : ContentPage
    {
        public PantallaMaterias()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}