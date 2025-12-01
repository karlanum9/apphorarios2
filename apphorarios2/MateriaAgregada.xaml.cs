using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class MateriaAgregada : ContentPage
    {
        public MateriaAgregada()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}