using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class MateriaEliminada : ContentPage
    {
        public MateriaEliminada()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}