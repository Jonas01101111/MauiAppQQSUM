namespace MauiAppQQSUM
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void EasyRoll_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomPerguntaFacil();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {

        }
    }

}
