using MauiAppQQSUM.Models;

namespace MauiAppQQSUM
{
    public partial class MainPage : ContentPage
    {
        double premio = 0;
        int pergunta_count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void EasyRoll_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomPerguntaFacil();
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ((bool) alt0.Value)
                    {
                    acertou = true;
                    resp = alt0.Content.ToString();
                }
            }
            if (alt1.IsChecked)
            {
                if ((bool) alt1.Value)
                    {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }
            if (alt2.IsChecked)
            {
                if ((bool) alt2.Value)
                    {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }
            if (alt3.IsChecked)
            {
                if ((bool) alt3.Value)
                    {
                    acertou = true;
                    resp = alt3.Content.ToString();
                }
            }

            if (acertou) {
                await DisplayAlert("ACERTOU!!!!", resp, "OK");
                this.BindingContext = App.getRandomPerguntaFacil();
                pergunta_count++;
            } else
            {
                await DisplayAlert("ERROU", "Perdeu tudo, não consegue né Moisés?", "OK");
            }
        }

        void avanca_pergunta()
        {
            if (pergunta_count <= 5)
            {
                premio += 1000;
                this.BindingContext = App.getRandomPerguntaFacil();
            }

            if (pergunta_count > 5 && pergunta_count <= 10)
            {
                premio += 10000;
                this.BindingContext = App.getRandomPerguntaMedia();
                if (pergunta_count > 10 && pergunta_count < 15)
                {
                    premio += 100000;
                    this.BindingContext = App.getRandomPerguntaDificil();
                }
            }

        }
    }
}
