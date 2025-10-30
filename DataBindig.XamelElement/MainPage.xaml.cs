namespace DataBindig.XamelElement
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            TextEntry.Text = "";
        }


        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextEntry.Text = TextEntry.Text;
        }
    }
}
