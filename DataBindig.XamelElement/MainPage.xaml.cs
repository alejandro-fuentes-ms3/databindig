namespace DataBindig.XamelElement
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            EnteredTextLabel.Text = "";
        }


        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            EnteredTextLabel.Text = TextEntry.Text;
        }
    }
}
