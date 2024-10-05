//ALISON GISELLE ESCOTO SAUCEDA - 202210010098
namespace Ejercicio_1._1___Calculadora;

public partial class ResultView : ContentPage
{
	public ResultView(double res)
	{
		InitializeComponent();
        Resultado.Text = "" + res.ToString();
    }
}