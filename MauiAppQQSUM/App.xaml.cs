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
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUCA" },
                    new Alternativa {Correta = true, Descricao = "NEGRINHO DO PASTOREIO" },
                    new Alternativa {Correta = false, Descricao = "BOITATÁ" },
                    new Alternativa {Correta = false, Descricao = "SACI-PERERÊ" }
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual cantor é o pai da dupla Sandy e Júnior?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "LEONARDO" },
                    new Alternativa {Correta = true, Descricao = "XORORÓ" },
                    new Alternativa {Correta = false, Descricao = "ZEZÉ DI CAMARGO" },
                    new Alternativa {Correta = false, Descricao = "CHITÃOZINHO" }
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "PARANÁ" },
                    new Alternativa {Correta = true, Descricao = "SANTA CATARINA" },
                    new Alternativa {Correta = false, Descricao = "SÃO PAULO" },
                    new Alternativa {Correta = false, Descricao = "BAHIA" }
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando numa buzina?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "RAUL GIL" },
                    new Alternativa {Correta = true, Descricao = "BOLINHA" },
                    new Alternativa {Correta = false, Descricao = "FLÁVIO CAVALCANTI" },
                    new Alternativa {Correta = false, Descricao = "CHACRINHA" }
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Qual é o profissional que usa o estetoscópio?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ENGENHEIRO" },
                    new Alternativa {Correta = true, Descricao = "MECÂNICO" },
                    new Alternativa {Correta = false, Descricao = "MÉDICO" },
                    new Alternativa {Correta = false, Descricao = "AVIADOR" }
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Qual ser mitológico possui o corpo metade mulher e metade peixe?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "SEREIA" },
                    new Alternativa {Correta = true, Descricao = "MEDUSA" },
                    new Alternativa {Correta = false, Descricao = "CLEÓPATRA" },
                    new Alternativa {Correta = false, Descricao = "SERENA" }
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Em que cidade é realizada a corrida de São Silvestre?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "BELO HORIZONTE" },
                    new Alternativa {Correta = true, Descricao = "RIO DE JANEIRO" },
                    new Alternativa {Correta = false, Descricao = "SÃO PAULO" },
                    new Alternativa {Correta = false, Descricao = "SALVADOR" }
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Qual é o réptil que muda de cor conforme o lugar em que está?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "SAPO" },
                    new Alternativa {Correta = true, Descricao = "CAMALEÃO" },
                    new Alternativa {Correta = false, Descricao = "LAGARTO" },
                    new Alternativa {Correta = false, Descricao = "JACARÉ" }
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Turmalina é uma espécie de quê?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "FLOR" },
                    new Alternativa {Correta = true, Descricao = "FRUTO" },
                    new Alternativa {Correta = false, Descricao = "PEDRA" },
                    new Alternativa {Correta = false, Descricao = "VERDURA" }
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Quem é o inimigo do Piu-Piu nos desenhos animados?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "FÉLIX" },
                    new Alternativa {Correta = true, Descricao = "TOM" },
                    new Alternativa {Correta = false, Descricao = "FRAJOLA" },
                    new Alternativa {Correta = false, Descricao = "MINGAU" }
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Em qual país surgiu a máfia?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ESTADOS UNIDOS" },
                    new Alternativa {Correta = true, Descricao = "INGLATERRA" },
                    new Alternativa {Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa {Correta = false, Descricao = "ESPANHA" }
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a cor da pedra rubi?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "AZUL" },
                    new Alternativa {Correta = true, Descricao = "VERDE" },
                    new Alternativa {Correta = false, Descricao = "AMARELA" },
                    new Alternativa {Correta = false, Descricao = "VERMELHA" }
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "Quem é a mulher do Tarzan?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "DIANA" },
                    new Alternativa {Correta = true, Descricao = "LOUIS LAINE" },
                    new Alternativa {Correta = false, Descricao = "JANE" },
                    new Alternativa {Correta = false, Descricao = "CHITA" }
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "21 DE ABRIL" },
                    new Alternativa {Correta = true, Descricao = "12 DE OUTUBRO" },
                    new Alternativa {Correta = false, Descricao = "7 DE SETEMBRO" },
                    new Alternativa {Correta = false, Descricao = "25 DE DEZEMBRO" }
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Quando é comemorado o dia da criança?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "12 DE OUTUBRO" },
                    new Alternativa {Correta = true, Descricao = "1 DE ABRIL" },
                    new Alternativa {Correta = false, Descricao = "13 DE MAIO" },
                    new Alternativa {Correta = false, Descricao = "9 DE JULHO" }
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Qual era a profissão exercida por Lula, antes de ele ser presidente do PT?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ENGRAXATE" },
                    new Alternativa {Correta = true, Descricao = "PEDREIRO" },
                    new Alternativa {Correta = false, Descricao = "FEIRANTE" },
                    new Alternativa {Correta = false, Descricao = "METALÚRGICO" }
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO" },
                    new Alternativa {Correta = true, Descricao = "BARÃO DE MAUÁ" },
                    new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa {Correta = false, Descricao = "MARQUÊS DE POMBAL" }
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "HARRISON FORD" },
                    new Alternativa {Correta = true, Descricao = "GERALD FORD" },
                    new Alternativa {Correta = false, Descricao = "HENRY FORD" },
                    new Alternativa {Correta = false, Descricao = "ANNA FORD" }
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Como é chamada a gravura impressa sobre pranchas de madeira?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "MATEROGRAFIA" },
                    new Alternativa {Correta = true, Descricao = "LITOGRAFIA" },
                    new Alternativa {Correta = false, Descricao = "XILOGRAFIA" },
                    new Alternativa {Correta = false, Descricao = "SERIGRAFIA" }
                }
            }
        };




        List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "SEIS" },
                    new Alternativa {Correta = true, Descricao = "OITO" },
                    new Alternativa {Correta = false, Descricao = "DEZ" },
                    new Alternativa {Correta = false, Descricao = "DOZE" }
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Sashimi é um prato originário de qual país?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "JAPÃO" },
                    new Alternativa {Correta = true, Descricao = "CHINA" },
                    new Alternativa {Correta = false, Descricao = "ÍNDIA" },
                    new Alternativa {Correta = false, Descricao = "INDONÉSIA" }
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual cantor é o pai da dupla Sandy e Júnior?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "LEONARDO" },
                    new Alternativa {Correta = true, Descricao = "XORORÓ" },
                    new Alternativa {Correta = false, Descricao = "ZEZÉ DI CAMARGO" },
                    new Alternativa {Correta = false, Descricao = "CHITÃOZINHO" }
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "PARANÁ" },
                    new Alternativa {Correta = true, Descricao = "SANTA CATARINA" },
                    new Alternativa {Correta = false, Descricao = "SÃO PAULO" },
                    new Alternativa {Correta = false, Descricao = "BAHIA" }
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando numa buzina?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "RAUL GIL" },
                    new Alternativa {Correta = true, Descricao = "BOLINHA" },
                    new Alternativa {Correta = false, Descricao = "FLÁVIO CAVALCANTI" },
                    new Alternativa {Correta = false, Descricao = "CHACRINHA" }
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Qual é o profissional que usa o estetoscópio?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ENGENHEIRO" },
                    new Alternativa {Correta = true, Descricao = "MECÂNICO" },
                    new Alternativa {Correta = false, Descricao = "MÉDICO" },
                    new Alternativa {Correta = false, Descricao = "AVIADOR" }
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Qual ser mitológico possui o corpo metade mulher e metade peixe?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "SEREIA" },
                    new Alternativa {Correta = true, Descricao = "MEDUSA" },
                    new Alternativa {Correta = false, Descricao = "CLEÓPATRA" },
                    new Alternativa {Correta = false, Descricao = "SERENA" }
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Em que cidade é realizada a corrida de São Silvestre?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "BELO HORIZONTE" },
                    new Alternativa {Correta = true, Descricao = "RIO DE JANEIRO" },
                    new Alternativa {Correta = false, Descricao = "SÃO PAULO" },
                    new Alternativa {Correta = false, Descricao = "SALVADOR" }
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Qual é o réptil que muda de cor conforme o lugar em que está?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "SAPO" },
                    new Alternativa {Correta = true, Descricao = "CAMALEÃO" },
                    new Alternativa {Correta = false, Descricao = "LAGARTO" },
                    new Alternativa {Correta = false, Descricao = "JACARÉ" }
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Turmalina é uma espécie de quê?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "FLOR" },
                    new Alternativa {Correta = true, Descricao = "FRUTO" },
                    new Alternativa {Correta = false, Descricao = "PEDRA" },
                    new Alternativa {Correta = false, Descricao = "VERDURA" }
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Quem é o inimigo do Piu-Piu nos desenhos animados?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "FÉLIX" },
                    new Alternativa {Correta = true, Descricao = "TOM" },
                    new Alternativa {Correta = false, Descricao = "FRAJOLA" },
                    new Alternativa {Correta = false, Descricao = "MINGAU" }
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Em qual país surgiu a máfia?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ESTADOS UNIDOS" },
                    new Alternativa {Correta = true, Descricao = "INGLATERRA" },
                    new Alternativa {Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa {Correta = false, Descricao = "ESPANHA" }
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a cor da pedra rubi?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "AZUL" },
                    new Alternativa {Correta = true, Descricao = "VERDE" },
                    new Alternativa {Correta = false, Descricao = "AMARELA" },
                    new Alternativa {Correta = false, Descricao = "VERMELHA" }
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "Quem é a mulher do Tarzan?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "DIANA" },
                    new Alternativa {Correta = true, Descricao = "LOUIS LAINE" },
                    new Alternativa {Correta = false, Descricao = "JANE" },
                    new Alternativa {Correta = false, Descricao = "CHITA" }
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "21 DE ABRIL" },
                    new Alternativa {Correta = true, Descricao = "12 DE OUTUBRO" },
                    new Alternativa {Correta = false, Descricao = "7 DE SETEMBRO" },
                    new Alternativa {Correta = false, Descricao = "25 DE DEZEMBRO" }
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Quando é comemorado o dia da criança?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "12 DE OUTUBRO" },
                    new Alternativa {Correta = true, Descricao = "1 DE ABRIL" },
                    new Alternativa {Correta = false, Descricao = "13 DE MAIO" },
                    new Alternativa {Correta = false, Descricao = "9 DE JULHO" }
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Qual era a profissão exercida por Lula, antes de ele ser presidente do PT?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ENGRAXATE" },
                    new Alternativa {Correta = true, Descricao = "PEDREIRO" },
                    new Alternativa {Correta = false, Descricao = "FEIRANTE" },
                    new Alternativa {Correta = false, Descricao = "METALÚRGICO" }
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO" },
                    new Alternativa {Correta = true, Descricao = "BARÃO DE MAUÁ" },
                    new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa {Correta = false, Descricao = "MARQUÊS DE POMBAL" }
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "HARRISON FORD" },
                    new Alternativa {Correta = true, Descricao = "GERALD FORD" },
                    new Alternativa {Correta = false, Descricao = "HENRY FORD" },
                    new Alternativa {Correta = false, Descricao = "ANNA FORD" }
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Como é chamada a gravura impressa sobre pranchas de madeira?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "MATEROGRAFIA" },
                    new Alternativa {Correta = true, Descricao = "LITOGRAFIA" },
                    new Alternativa {Correta = false, Descricao = "XILOGRAFIA" },
                    new Alternativa {Correta = false, Descricao = "SERIGRAFIA" }
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
