namespace _4955511ProgramasP11;

/// <summary> Se crea una aplicacion que devuelve el total que debe pagar una los galones surtidos al cliente convirtiendolos a litros para multiplicarlos por el precio por litro /// </summary>
/// <LastAutorModification> Marcos Noe Vasquez Guardado </LastAutorModification>
/// <LastModification> 24/06/2024 </LastModification>

public partial class Gasolinera : ContentPage
{
	public Gasolinera()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		double plitros;
		int Galones;
		double Galoneasalitros; 
		double CobroCliente;


		//Asigna el valor a la variable galones que se surtieron al cliente
		Galones = Convert.ToInt32(GSurtidos.Text);

		//Asigna el valor a la varible precio por litro
		plitros = Convert.ToDouble(PpLitro.Text);


		//Se convierten los galones a litros 
		Galoneasalitros = (Galones * 3.78541);

		//Luego de la conversion de galones a litros se multiplican los litros obtenidos por el precio del equivalente de cada galon y se redondea el total a dos decimales
		 CobroCliente=Math.Round(Galoneasalitros* plitros,2);

		//Muestra cuanto se le debe cobrar al cliente ya convertido el precio en litros 
		CCliente.Text = CobroCliente.ToString();
    }
}