namespace MenuPractica11;

public partial class CambioCliente : ContentPage
{
	public CambioCliente()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(EntryCosto.Text) && !String.IsNullOrEmpty(EntryDinero.Text))
        {
            double Costo, Dinero;

            if (double.TryParse(EntryCosto.Text, out Costo) && double.TryParse(EntryDinero.Text, out Dinero))
            {
                double Cambio = Dinero - Costo;

                EntryCambio.Text = Cambio.ToString();
            }
            else
            {
                DisplayAlert("Error", "Solo se acepta numeros", "OK");
            }
        }
        else
        {
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