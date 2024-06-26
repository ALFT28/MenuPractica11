using _4955511ProgramasP11;

namespace MenuPractica11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dinosaurio());
        }
        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Triangulo());
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CambioCliente());
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gasolinera());
        }
    }

}
