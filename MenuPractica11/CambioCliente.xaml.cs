namespace MenuPractica11;

public partial class CambioCliente : ContentPage
{
	public CambioCliente()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Se verifica si los campos de texto EntryCosto y EntryDinero no están vacíos.
        if (!String.IsNullOrEmpty(EntryCosto.Text) && !String.IsNullOrEmpty(EntryDinero.Text))
        {
            //El EntryCosto y EntryDinero se convierte a tipo double se realiza con double.TryParse y que vuleve verdadero si la convercion es exitosa.
            if (double.TryParse(EntryCosto.Text, out double Costo) && double.TryParse(EntryDinero.Text, out double Dinero))
            {
                //Se decalra una variable double llamada Cambio donde se guardara el calculo
                //Se calcula el cambio restando Costo de Dinero.
                double Cambio = Dinero - Costo;


                //Cambio se convierte a una cadena de texto Y
                //Se le asigna al EntryCambio 
                EntryCambio.Text = Cambio.ToString();
            }
            else
            {
                //Si los valores ingresados no son números válidos se muostrara una alerta
                DisplayAlert("Error", "Solo se acepta numeros", "OK");
            }
        }
        else
        { //Si los campos de texto estan vacios se mostrara una alerta
            DisplayAlert("Error", "Porfavor agregue los numeros", "OK");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        EntryCambio.Text = "";
        EntryCosto.Text = "";
        EntryDinero.Text = "";
    }
}