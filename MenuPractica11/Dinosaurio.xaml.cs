namespace MenuPractica11;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}


    private void Button_Clicked_1(object sender, EventArgs e)
    {
        //Se verifica si los campos de texto EntryKg y EntryMts no están vacíos.
        if (!String.IsNullOrEmpty(EntryKg.Text) && !String.IsNullOrEmpty(EntryMts.Text))
        {
            //El EntryKg y EntryMts se convierte a tipo double se realiza con double.TryParse y que vuleve verdadero si la convercion es exitosa.
            if (double.TryParse(EntryKg.Text, out double KG) && double.TryParse(EntryMts.Text, out double MTS))
            {
                //Se declaran dos variable tipo double la cual CM Tendra el valor de 100
                //Y LB tendra el valor de 2.20462
                double CM = 100, LB = 2.20462;


                //Se declara la variable converion1 tipo double la cual hara la multiplicara de Kg por Lb
                double Conversion1 = KG * LB;
                //Se declara la variable converion2 tipo double la cual hara la multiplicara de Mts por Cm
                double Conversion2 = MTS * CM;

                //El resultados de las conversiones se convierten a
                //cadenas de texto y se asignan a
                //los campos de texto EntryLb y EntryCm
                EntryLb.Text = Conversion1.ToString();
                EntryCm.Text = Conversion2.ToString();


            }
            else
            { //Si los valores ingresados no son números válidos se muostrara una alerta
                DisplayAlert("Error", "Por favor introduce solo números válidos.", "Ok");
            }
        }
        else
        {//Si los campos de texto estan vacios se mostrara una alerta
            DisplayAlert("Error", "Introduce los numeros", "Ok");
        }

    }


    private void Button_Clicked(object sender, EventArgs e)
    {
        EntryKg.Text = "";
        EntryCm.Text = "";
        EntryMts.Text = "";
        EntryLb.Text = "";
    }
}