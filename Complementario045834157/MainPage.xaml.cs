namespace Complementario045834157
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Obtendra los valores ingredados en los diferentes entry
            if (int.TryParse(NumberEntry.Text, out int number) && number > 0)
            {
                //Hará la conversión de los numeros positivos enteros ingresados(Triangulo y cubo)
                int triangulo = number * number;
                int cubo = number * number * number;

                //Mostrará el resultado de la ecuación realizada del triangulo y cubo del numero positivo
                TrianguloResultado.Text = $"Cuadrado: {triangulo}";
                CuboResultado.Text = $"Cubo: {cubo}";
            }
            
        }
    }

}
