using MauiAppQQSUM.Models;

namespace MauiAppQQSUM
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "Líquido" },
                    new Alternativa {Correta = true, Descricao = "Sólido" },
                    new Alternativa {Correta = false, Descricao = "Gasoso" },
                    new Alternativa {Correta = false, Descricao = "Vaporoso" }
                }
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
