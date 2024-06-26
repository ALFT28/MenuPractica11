namespace MenuPractica11;

public partial class Triangulo : ContentPage
{
    public Triangulo()
    {
        InitializeComponent();
    }
    private void CalcularButton_Clicked(object sender, EventArgs e)
    {
        // Obtener la base y altura desde las cajas de texto
        if (double.TryParse(BaseEntry.Text, out double baseTriangulo) &&
            double.TryParse(AlturaEntry.Text, out double alturaTriangulo))
        {
            // Calcular la superficie del tri�ngulo
            double superficie = (baseTriangulo * alturaTriangulo) / 2;

            // Mostrar la superficie en el etiqueta de resultado
            SuperficieLabel.Text = $"Superficie del tri�ngulo: {superficie}";
        }
        else
        {
            // Mostrar un mensaje de error si la entrada no es v�lida
            SuperficieLabel.Text = "Por favor ingrese n�meros v�lidos para base y altura.";
        }
    }
}