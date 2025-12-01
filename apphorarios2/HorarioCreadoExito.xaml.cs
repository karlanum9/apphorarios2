using Microsoft.Maui.Controls;

namespace apphorarios2
{
    public partial class HorarioCreadoExito : ContentPage
    {
        public HorarioCreadoExito()
        {
            InitializeComponent();
        }

        private void BtnVolver_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}