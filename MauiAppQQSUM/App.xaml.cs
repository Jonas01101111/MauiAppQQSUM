using MauiAppQQSUM.Models;

namespace MauiAppQQSUM
{
    public partial class App : Application
    {
        static List<Pergunta> perguntas_faceis = new()
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
                    new Alternativa {Correta = false, Descricao = "NEGRINHO DO PASTOREIO" },
                    new Alternativa {Correta = false, Descricao = "BOITATÁ" },
                    new Alternativa {Correta = true, Descricao = "SACI-PERERÊ" }
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
                    new Alternativa {Correta = false, Descricao = "SANTA CATARINA" },
                    new Alternativa {Correta = false, Descricao = "SÃO PAULO" },
                    new Alternativa {Correta = true, Descricao = "BAHIA" }
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando numa buzina?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "RAUL GIL" },
                    new Alternativa {Correta = false, Descricao = "BOLINHA" },
                    new Alternativa {Correta = false, Descricao = "FLÁVIO CAVALCANTI" },
                    new Alternativa {Correta = true, Descricao = "CHACRINHA" }
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Qual é o profissional que usa o estetoscópio?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ENGENHEIRO" },
                    new Alternativa {Correta = false, Descricao = "MECÂNICO" },
                    new Alternativa {Correta = true, Descricao = "MÉDICO" },
                    new Alternativa {Correta = false, Descricao = "AVIADOR" }
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Qual ser mitológico possui o corpo metade mulher e metade peixe?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "SEREIA" },
                    new Alternativa {Correta = false, Descricao = "MEDUSA" },
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
                    new Alternativa {Correta = false, Descricao = "RIO DE JANEIRO" },
                    new Alternativa {Correta = true, Descricao = "SÃO PAULO" },
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
                    new Alternativa {Correta = false, Descricao = "FRUTO" },
                    new Alternativa {Correta = true, Descricao = "PEDRA" },
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
                    new Alternativa {Correta = false, Descricao = "TOM" },
                    new Alternativa {Correta = true, Descricao = "FRAJOLA" },
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
                    new Alternativa {Correta = false, Descricao = "INGLATERRA" },
                    new Alternativa {Correta = true, Descricao = "ITÁLIA" },
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
                    new Alternativa {Correta = false, Descricao = "VERDE" },
                    new Alternativa {Correta = false, Descricao = "AMARELA" },
                    new Alternativa {Correta = true, Descricao = "VERMELHA" }
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "Quem é a mulher do Tarzan?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "DIANA" },
                    new Alternativa {Correta = false, Descricao = "LOUIS LAINE" },
                    new Alternativa {Correta = false, Descricao = "JANE" },
                    new Alternativa {Correta = true, Descricao = "CHITA" }
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "21 DE ABRIL" },
                    new Alternativa {Correta = false, Descricao = "12 DE OUTUBRO" },
                    new Alternativa {Correta = true, Descricao = "7 DE SETEMBRO" },
                    new Alternativa {Correta = false, Descricao = "25 DE DEZEMBRO" }
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Quando é comemorado o dia da criança?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "12 DE OUTUBRO" },
                    new Alternativa {Correta = false, Descricao = "1 DE ABRIL" },
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
                    new Alternativa {Correta = false, Descricao = "PEDREIRO" },
                    new Alternativa {Correta = false, Descricao = "FEIRANTE" },
                    new Alternativa {Correta = true, Descricao = "METALÚRGICO" }
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO" },
                    new Alternativa {Correta = false, Descricao = "BARÃO DE MAUÁ" },
                    new Alternativa {Correta = true, Descricao = "DUQUE DE CAXIAS" },
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
                    new Alternativa {Correta = false, Descricao = "GERALD FORD" },
                    new Alternativa {Correta = true, Descricao = "HENRY FORD" },
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
                    new Alternativa {Correta = false, Descricao = "LITOGRAFIA" },
                    new Alternativa {Correta = true, Descricao = "XILOGRAFIA" },
                    new Alternativa {Correta = false, Descricao = "SERIGRAFIA" }
                }
            }
        };




        static List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "SEIS" },
                    new Alternativa {Correta = false, Descricao = "OITO" },
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
                    new Alternativa {Correta = true, Descricao = "JAPÃO" },
                    new Alternativa {Correta = false, Descricao = "CHINA" },
                    new Alternativa {Correta = false, Descricao = "ÍNDIA" },
                    new Alternativa {Correta = false, Descricao = "INDONÉSIA" }
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Como é chamado quem nasce em Milão, na Itália?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "MILANENSE" },
                    new Alternativa {Correta = false, Descricao = "MILANOSO" },
                    new Alternativa {Correta = false, Descricao = "MILISTA" },
                    new Alternativa {Correta = true, Descricao = "MILANÊS" }
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Que profissional usa uma ferramenta chamada formão?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "CARPINTEIRO" },
                    new Alternativa {Correta = false, Descricao = "RELOJOEIRO" },
                    new Alternativa {Correta = false, Descricao = "CONFEITEIRO" },
                    new Alternativa {Correta = false, Descricao = "BOMBEIRO" }
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Em qual estádio Pelé marcou seu milésimo gol?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "MORUMBI" },
                    new Alternativa {Correta = false, Descricao = "PACAEMBU" },
                    new Alternativa {Correta = true, Descricao = "MARACANÃ" },
                    new Alternativa {Correta = false, Descricao = "MINEIRÃO" }
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "O que é um oboé?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "VULCÃO" },
                    new Alternativa {Correta = false, Descricao = "COMIDA" },
                    new Alternativa {Correta = true, Descricao = "INSTRUMENTO MUSICAL" },
                    new Alternativa {Correta = false, Descricao = "TRIBO INDÍGENA" }
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "KAMIKAZES" },
                    new Alternativa {Correta = false, Descricao = "SASHIMIS" },
                    new Alternativa {Correta = false, Descricao = "HARAQUIRIS" },
                    new Alternativa {Correta = false, Descricao = "SUMÔS" }
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "O que é gôndola?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "EMBARCAÇÃO" },
                    new Alternativa {Correta = false, Descricao = "BRINQUEDO" },
                    new Alternativa {Correta = false, Descricao = "MÚSICA" },
                    new Alternativa {Correta = false, Descricao = "SÍMBOLO" }
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Quantos quilates tem o ouro puro?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "18" },
                    new Alternativa {Correta = false, Descricao = "20" },
                    new Alternativa {Correta = true, Descricao = "24" },
                    new Alternativa {Correta = false, Descricao = "30" }
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Segundo a crença popular, a mula-sem-cabeça é mulher de quem?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "DO COROINHA" },
                    new Alternativa {Correta = true, Descricao = "DO PADRE" },
                    new Alternativa {Correta = false, Descricao = "DO SACRISTÃO" },
                    new Alternativa {Correta = false, Descricao = "DO BISPO" }
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "BILL" },
                    new Alternativa {Correta = true, Descricao = "CLYDE" },
                    new Alternativa {Correta = false, Descricao = "JAMES" },
                    new Alternativa {Correta = false, Descricao = "BUTCH" }
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Qual é a moeda oficial da Alemanha?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "LIRA" },
                    new Alternativa {Correta = false, Descricao = "MARCO" },
                    new Alternativa {Correta = false, Descricao = "FRANCO" },
                    new Alternativa {Correta = true, Descricao = "LIBRA" }
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Quem é o parceiro de aventuras de Dom Quixote?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "SANCHO PANÇA" },
                    new Alternativa {Correta = false, Descricao = "GUILHERME TELL" },
                    new Alternativa {Correta = false, Descricao = "SIGMUND FREUD" },
                    new Alternativa {Correta = false, Descricao = "LANCELOT" }
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "Que metal avermelhado cria uma camada esverdeada em contato com a umidade?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "FERRO" },
                    new Alternativa {Correta = true, Descricao = "COBRE" },
                    new Alternativa {Correta = false, Descricao = "MERCÚRIO" },
                    new Alternativa {Correta = false, Descricao = "AÇO" }
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Que planta era usada para fabricação de papel no antigo Egito?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "PAPIRO" },
                    new Alternativa {Correta = false, Descricao = "EUCALIPTO" },
                    new Alternativa {Correta = false, Descricao = "OLIVEIRA" },
                    new Alternativa {Correta = false, Descricao = "MILHO" }
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Que país europeu tem como atração a tourada?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "ESPANHA" },
                    new Alternativa {Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa {Correta = false, Descricao = "FRANÇA" },
                    new Alternativa {Correta = false, Descricao = "ALEMANHA" }
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "O que os filatelistas colecionam?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "QUADROS" },
                    new Alternativa {Correta = false, Descricao = "MOEDAS" },
                    new Alternativa {Correta = true, Descricao = "SELOS" },
                    new Alternativa {Correta = false, Descricao = "FIGURINHAS" }
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO" },
                    new Alternativa {Correta = false, Descricao = "BARÃO DE MAUÁ" },
                    new Alternativa {Correta = true, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa {Correta = false, Descricao = "MARQUÊS DE POMBAL" }
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Qual é o país que participou de todas as copas do mundo de futebol, até 1998?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa {Correta = false, Descricao = "URUGUAI" },
                    new Alternativa {Correta = false, Descricao = "ARGENTINA" },
                    new Alternativa {Correta = true, Descricao = "BRASIL " }
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "O nome América foi associado a qual desses nomes?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "AMÉRICO DOS REIS" },
                    new Alternativa {Correta = true, Descricao = "AMÉRICO BRASILIENSE" },
                    new Alternativa {Correta = true, Descricao = "AMÉRICO VESPÚCIO" },
                    new Alternativa {Correta = false, Descricao = "JOSÉ AMÉRICO DA SILVA" }
                }
            }
        };


        static List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "POLÔNIA" },
                    new Alternativa {Correta = false, Descricao = "FRANÇA" },
                    new Alternativa {Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa {Correta = true, Descricao = "HOLANDA" }
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual presidente brasileiro instituiu o AI-5?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "COSTA E SILVA" },
                    new Alternativa {Correta = false, Descricao = "ERNESTO GEISEL" },
                    new Alternativa {Correta = false, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa {Correta = false, Descricao = "ITAMAR FRANCO" }
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "O que significa literalmente Perestroika?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "CONVERSÃO" },
                    new Alternativa {Correta = false, Descricao = "INVOLUÇÃO" },
                    new Alternativa {Correta = true, Descricao = "REESTRUTURAÇÃO" },
                    new Alternativa {Correta = false, Descricao = "REGRESSÃO" }
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Qual desses quatro pesos é o mais leve?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "10 ONÇAS" },
                    new Alternativa {Correta = true, Descricao = "10 GRAMAS" },
                    new Alternativa {Correta = false, Descricao = "10 QUILOS" },
                    new Alternativa {Correta = false, Descricao = "10 LIBRAS" }
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Brahma é o deus de que religião?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "HINDUÍSMO" },
                    new Alternativa {Correta = false, Descricao = "XINTOÍSMO" },
                    new Alternativa {Correta = false, Descricao = "BUDISMO" },
                    new Alternativa {Correta = false, Descricao = "ISLAMISMO" }
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Os nazistas foram julgados em:",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "BERLIM" },
                    new Alternativa {Correta = true, Descricao = "NUREMBERGUE" },
                    new Alternativa {Correta = false, Descricao = "MUNIQUE" },
                    new Alternativa {Correta = false, Descricao = "PARIS" }
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Qual oceano tem o maior volume de água? ",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ATLÂNTICO" },
                    new Alternativa {Correta = true, Descricao = "PACÍFICO" },
                    new Alternativa {Correta = false, Descricao = "ÍNDICO" },
                    new Alternativa {Correta = false, Descricao = "ÁRTICO" }
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Qual foi o último presidente militar do Brasil?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "FERNANDO COLLOR" },
                    new Alternativa {Correta = true, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa {Correta = false, Descricao = "TANCREDO NEVES" },
                    new Alternativa {Correta = false, Descricao = "JOÃO GOULART" }
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "O que são meninges?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "CÉLULAS" },
                    new Alternativa {Correta = false, Descricao = "NERVOS" },
                    new Alternativa {Correta = true, Descricao = "MEMBRANAS" },
                    new Alternativa {Correta = false, Descricao = "MÚSCULOS" }
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Qual produto gerou guerras e conflitos no século XX?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "ÁLCOOL" },
                    new Alternativa {Correta = true, Descricao = "PETRÓLEO" },
                    new Alternativa {Correta = false, Descricao = "OURO" },
                    new Alternativa {Correta = false, Descricao = "ALUMÍNIO" }
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "O confucionismo é uma filosofia de qual nacionalidade?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "INDIANA" },
                    new Alternativa {Correta = false, Descricao = "JAPONESA" },
                    new Alternativa {Correta = true, Descricao = "CHINESA" },
                    new Alternativa {Correta = false, Descricao = "COREANA" }
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "A eletrônica é parte de qual ciência?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "FÍSICA" },
                    new Alternativa {Correta = false, Descricao = "BIOLOGIA" },
                    new Alternativa {Correta = false, Descricao = "QUÍMICA" },
                    new Alternativa {Correta = false, Descricao = "BOTÂNICA" }
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Que parte do corpo humano é infectada pela cólera?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "GARGANTA" },
                    new Alternativa {Correta = true, Descricao = "INTESTINO" },
                    new Alternativa {Correta = false, Descricao = "PULMÕES" },
                    new Alternativa {Correta = false, Descricao = "RINS" }
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "Em que país você pode gastar rublos?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "HOLANDA" },
                    new Alternativa {Correta = true, Descricao = "RÚSSIA" },
                    new Alternativa {Correta = false, Descricao = "ESPANHA" },
                    new Alternativa {Correta = false, Descricao = "ÁFRICA DO SUL" }
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "De quem é este verso: “A praça é do povo, como o céu é do condor”?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "TOBIAS BARRETO " },
                    new Alternativa {Correta = false, Descricao = "DORIVAL CAIMI" },
                    new Alternativa {Correta = false, Descricao = "MACHADO DE ASSIS" },
                    new Alternativa {Correta = true, Descricao = "CASTRO ALVES" }
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Em que ano Ayrton Senna venceu o primeiro campeonato de Fórmula 1? ",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "1987" },
                    new Alternativa {Correta = false, Descricao = "1990" },
                    new Alternativa {Correta = false, Descricao = "1985" },
                    new Alternativa {Correta = true, Descricao = "1988" }
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "O que os filatelistas colecionam?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "QUADROS" },
                    new Alternativa {Correta = false, Descricao = "MOEDAS" },
                    new Alternativa {Correta = true, Descricao = "SELOS" },
                    new Alternativa {Correta = false, Descricao = "FIGURINHAS" }
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Qual é a menor República do mundo?",
                Alternativa = new()
                {
                    new Alternativa {Correta = true, Descricao = "MÔNACO" },
                    new Alternativa {Correta = false, Descricao = "SAN MARINO" },
                    new Alternativa {Correta = false, Descricao = "NOVA ZELÂNDIA" },
                    new Alternativa {Correta = false, Descricao = "CHINA" }
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "De quem é a frase ”Penso, logo existo”?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "PLATÃO" },
                    new Alternativa {Correta = false, Descricao = "JÚLIO VERNE" },
                    new Alternativa {Correta = false, Descricao = "ARISTÓTELES" },
                    new Alternativa {Correta = true, Descricao = "RENÉ DESCARTES" }
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "O que construía Stradivarius?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "CASAS" },
                    new Alternativa {Correta = true, Descricao = "VIOLINOS" },
                    new Alternativa {Correta = false, Descricao = "ARMAS" },
                    new Alternativa {Correta = false, Descricao = "ESTRADAS" }
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
