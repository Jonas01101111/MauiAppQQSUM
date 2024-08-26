namespace MauiAppQQSUM
{
    public partial class MainPage : ContentPage
    {
        

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
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if (bool) alt0.Value)
                    {
                    acertou = true;
                    resp = alt0.Content.ToString();
                    }
            }
            if (alt1.IsChecked)
            {
                if (bool) alt1.Value)
                    {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }
            if (alt2.IsChecked)
            {
                if (bool) alt2.Value)
                    {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }
            if (alt3.IsChecked)
            {
                if (bool) alt3.Value)
                    {
                    acertou = true;
                    resp = alt3.Content.ToString();
                }
            }

        }
    }

}
