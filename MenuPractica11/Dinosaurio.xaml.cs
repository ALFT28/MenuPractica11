namespace MenuPractica11;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        EntryKg.Text = "";
        EntryCm.Text = "";
        EntryMts.Text = "";
        EntryLb.Text = "";
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(EntryKg.Text) && !String.IsNullOrEmpty(EntryMts.Text))
        {
            double KG, MTS, CM = 100, LB = 2.20462;

            if (double.TryParse(EntryKg.Text, out KG) && double.TryParse(EntryMts.Text, out MTS))
            {

                double Conversion1 = KG * LB;
                double Conversion2 = MTS * CM;

                EntryLb.Text = Conversion1.ToString();
                EntryCm.Text = Conversion2.ToString();


            }
            else
            {
                DisplayAlert("Error", "Por favor introduce solo números válidos.", "Ok");
            }
        }
        else
        {
            DisplayAlert("Error", "Introduce los numeros", "Ok");
        }
    }
}