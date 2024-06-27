using _4955511ProgramasP11;

namespace MenuPractica11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //boton para abrir la pagina de Dinosaurio
        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dinosaurio());
        }
        //boton para abrir el programa de Triangulo
        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Triangulo());
        }
        //boton para abrir el programa de Cambio Cliente
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CambioCliente());
        }
        //boton para abrir el programa de Gasolinera
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gasolinera());
        }
    }

}
