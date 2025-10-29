using DataBindig.DataObject.models;

namespace DataBindig.DataObject
{
    public partial class MainPage : ContentPage
    {


        private Contador contador;

        public MainPage()

        {

            InitializeComponent();
            contador = new Contador();

            //ConteoLabel.Text = contador.Conteo.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            contador.Reiniciar();
            //ConteoLabel.Text = contador.Conteo.ToString();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            contador.Contar();
            //ConteoLabel.Text = contador.Conteo.ToString();

        }



    }
}
