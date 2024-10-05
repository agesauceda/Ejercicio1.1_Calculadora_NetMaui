//ALISON GISELLE ESCOTO SAUCEDA - 202210010098
namespace Ejercicio_1._1___Calculadora
{
    public partial class MainPage : ContentPage
    {
        funciones fun = new funciones();

        public MainPage()
        {
            InitializeComponent();
        }

        public async void EvSuma(object sender, EventArgs e)
        {
            if (double.TryParse(Num1.Text, out double x) &&
                double.TryParse(Num2.Text, out double y))
            {
                double res = fun.Suma(x, y);
                await Navigation.PushAsync(new ResultView(res));
                clear();
            }
            else
            {
                await DisplayAlert("ERROR", "ESCRIBE NÚMEROS VALIDOS", "OK");
            }
        }

        public async void EvResta(object sender, EventArgs e)
        {
            if (double.TryParse(Num1.Text, out double x) &&
                double.TryParse(Num2.Text, out double y))
            {
                double res = fun.Resta(x, y);
                await Navigation.PushAsync(new ResultView(res));
                clear();
            }
            else
            {
                await DisplayAlert("ERROR", "ESCRIBE NÚMEROS VALIDOS", "OK");
            }
        }

        public async void EvMultiplicacion(object sender, EventArgs e)
        {
            if (double.TryParse(Num1.Text, out double x) &&
                double.TryParse(Num2.Text, out double y))
            {
                double res = fun.Multiplicacion(x, y);
                await Navigation.PushAsync(new ResultView(res));
                clear();
            }
            else
            {
                await DisplayAlert("ERROR", "ESCRIBE NÚMEROS VALIDOS", "OK");
            }
        }

        public async void EvDivision(object sender, EventArgs e)
        {
            if (double.TryParse(Num1.Text, out double x) &&
                double.TryParse(Num2.Text, out double y))
            {
                try
                {
                    double res = fun.Division(x, y);
                    await Navigation.PushAsync(new ResultView(res));
                    clear();
                }
                catch (DivideByZeroException ex)
                {
                    await DisplayAlert("ERROR", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("ERROR", "ESCRIBE NÚMEROS VALIDOS", "OK");
            }
        }

        private void clear()
        {
            Num1.Text = string.Empty;
            Num2.Text = string.Empty;
        }
    }
}


