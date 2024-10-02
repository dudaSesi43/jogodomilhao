namespace jogodomilhao;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador(Label pergunta,Button Resposta01,Button Resposta02,Button Resposta03,Button Resposta04, Button Resposta05)
    {
        CriarQuestoes(pergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
    }
    void CriarQuestoes(Label pergunta,Button Resposta01,Button Resposta02,Button Resposta03,Button Resposta04, Button Resposta05)
    {
        var Q1 = new Questao();
Q1.pergunta = "Qual é a capital do Brasil?";
Q1.Resposta01 = "Rio de Janeiro";
Q1.Resposta02 = "São Paulo";
Q1.Resposta03 = "Brasília";
Q1.Resposta04 = "Salvador";
Q1.RespostaCorreta = 03;
ListaQuestoes.Add(Q1);

       var Q2 = new Questao();
Q2.pergunta = "Quantos minutos há em uma hora?";
Q2.Resposta01 = "30 minutos";
Q2.Resposta02 = "45 minutos";
Q2.Resposta03 = "60 minutos";
Q2.Resposta04 = "90 minutos";
Q2.RespostaCorreta = 03;
ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
Q3.pergunta = "Qual é o maior planeta do sistema solar?";
Q3.Resposta01 = "Marte";
Q3.Resposta02 = "Júpiter";
Q3.Resposta03 = "Saturno";
Q3.Resposta04 = "Terra";
Q3.RespostaCorreta = 02;
ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
Q4.pergunta = "Quem pintou a Mona Lisa?";
Q4.Resposta01 = "Pablo Picasso";
Q4.Resposta02 = "Leonardo da Vinci";
Q4.Resposta03 = "Michelangelo";
Q4.Resposta04 = "Vincent van Gogh";
Q4.RespostaCorreta = 02;
ListaQuestoes.Add(Q4);

       var Q5 = new Questao();
Q5.pergunta = "Quantos dias tem um ano bissexto?";
Q5.Resposta01 = "364";
Q5.Resposta02 = "365";
Q5.Resposta03 = "366";
Q5.Resposta04 = "367";
Q5.RespostaCorreta = 03;
ListaQuestoes.Add(Q5);

       var Q6 = new Questao();
Q6.pergunta = "Em que continente está localizado o Egito?";
Q6.Resposta01 = "Europa";
Q6.Resposta02 = "Ásia";
Q6.Resposta03 = "África";
Q6.Resposta04 = "Oceania";
Q6.RespostaCorreta = 03;
ListaQuestoes.Add(Q6);

       var Q7 = new Questao();
Q7.pergunta = "Em que país fica a Torre Eiffel?";
Q7.Resposta01 = "Itália";
Q7.Resposta02 = "Alemanha";
Q7.Resposta03 = "França";
Q7.Resposta04 = "Espanha";
Q7.RespostaCorreta = 03;
ListaQuestoes.Add(Q7);

var Q8 = new Questao();
Q8.pergunta = "Qual é o menor país do mundo?";
Q8.Resposta01 = "Mônaco";
Q8.Resposta02 = "Vaticano";
Q8.Resposta03 = "Luxemburgo";
Q8.Resposta04 = "Andorra";
Q8.RespostaCorreta = 02;
ListaQuestoes.Add(Q8);

var Q9 = new Questao();
Q9.pergunta = "Quantos estados tem o Brasil?";
Q9.Resposta01 = "25";
Q9.Resposta02 = "26";
Q9.Resposta03 = "27";
Q9.Resposta04 = "28";
Q9.RespostaCorreta = 03;
ListaQuestoes.Add(Q9);

var Q10 = new Questao();
Q10.pergunta = "Qual é o nome do maior oceano da Terra?";
Q10.Resposta01 = "Atlântico";
Q10.Resposta02 = "Índico";
Q10.Resposta03 = "Pacífico";
Q10.Resposta04 = "Ártico";
Q10.RespostaCorreta = 03;
ListaQuestoes.Add(Q10);

var Q11 = new Questao();
Q11.pergunta = "Qual é o país mais populoso do mundo?";
Q11.Resposta01 = "Estados Unidos";
Q11.Resposta02 = "Índia";
Q11.Resposta03 = "China";
Q11.Resposta04 = "Rússia";
Q11.RespostaCorreta = 03;
ListaQuestoes.Add(Q11);

var Q12 = new Questao();
Q12.pergunta = "Quem foi o primeiro homem a pisar na Lua?";
Q12.Resposta01 = "Buzz Aldrin";
Q12.Resposta02 = "Yuri Gagarin";
Q12.Resposta03 = "Neil Armstrong";
Q12.Resposta04 = "John Glenn";
Q12.RespostaCorreta = 03;
ListaQuestoes.Add(Q12);

var Q13 = new Questao();
Q13.pergunta = "Qual é o maior continente do mundo?";
Q13.Resposta01 = "África";
Q13.Resposta02 = "Europa";
Q13.Resposta03 = "Ásia";
Q13.Resposta04 = "América do Sul";
Q13.RespostaCorreta = 03;
ListaQuestoes.Add(Q13);

var Q14 = new Questao();
Q14.pergunta = "Quantos ossos tem o corpo humano adulto?";
Q14.Resposta01 = "205";
Q14.Resposta02 = "206";
Q14.Resposta03 = "207";
Q14.Resposta04 = "208";
Q14.RespostaCorreta = 02;
ListaQuestoes.Add(Q14);

var Q15 = new Questao();
Q15.pergunta = "Quem escreveu 'Dom Quixote'?";
Q15.Resposta01 = "William Shakespeare";
Q15.Resposta02 = "Jorge Luis Borges";
Q15.Resposta03 = "Miguel de Cervantes";
Q15.Resposta04 = "Gabriel García Márquez";
Q15.RespostaCorreta = 03;
ListaQuestoes.Add(Q15);

var Q16 = new Questao();
Q16.pergunta = "Em que ano aconteceu a Proclamação da República no Brasil?";
Q16.Resposta01 = "1822";
Q16.Resposta02 = "1889";
Q16.Resposta03 = "1930";
Q16.Resposta04 = "1964";
Q16.RespostaCorreta = 02;
ListaQuestoes.Add(Q16);

var Q17 = new Questao();
Q17.pergunta = "Qual é o elemento químico representado pelo símbolo O?";
Q17.Resposta01 = "Oxigênio";
Q17.Resposta02 = "Ouro";
Q17.Resposta03 = "Ósmio";
Q17.Resposta04 = "Óxido de carbono";
Q17.RespostaCorreta = 01;
ListaQuestoes.Add(Q17);

var Q18 = new Questao();
Q18.pergunta = "Qual é o animal terrestre mais rápido do mundo?";
Q18.Resposta01 = "Leão";
Q18.Resposta02 = "Chita";
Q18.Resposta03 = "Guepardo";
Q18.Resposta04 = "Cavalo";
Q18.RespostaCorreta = 03;
ListaQuestoes.Add(Q18);

var Q19 = new Questao();
Q19.pergunta = "Em que país está localizada a Estátua da Liberdade?";
Q19.Resposta01 = "França";
Q19.Resposta02 = "Estados Unidos";
Q19.Resposta03 = "Reino Unido";
Q19.Resposta04 = "Canadá";
Q19.RespostaCorreta = 02;
ListaQuestoes.Add(Q19);

var Q20 = new Questao();
Q20.pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
Q20.Resposta01 = "Abraham Lincoln";
Q20.Resposta02 = "George Washington";
Q20.Resposta03 = "Thomas Jefferson";
Q20.Resposta04 = "John Adams";
Q20.RespostaCorreta = 02;
ListaQuestoes.Add(Q20);

var Q21 = new Questao();
Q21.pergunta = "Em que ano o homem chegou à Lua?";
Q21.Resposta01 = "1965";
Q21.Resposta02 = "1969";
Q21.Resposta03 = "1970";
Q21.Resposta04 = "1972";
Q21.RespostaCorreta = 02;
ListaQuestoes.Add(Q21);

var Q22 = new Questao();
Q22.pergunta = "Qual é a maior floresta tropical do mundo?";
Q22.Resposta01 = "Floresta Amazônica";
Q22.Resposta02 = "Floresta do Congo";
Q22.Resposta03 = "Floresta Negra";
Q22.Resposta04 = "Floresta de Borneo";
Q22.RespostaCorreta = 01;
ListaQuestoes.Add(Q22);

var Q23 = new Questao();
Q23.pergunta = "Qual é o maior mamífero do mundo?";
Q23.Resposta01 = "Elefante Africano";
Q23.Resposta02 = "Baleia Azul";
Q23.Resposta03 = "Tubarão Branco";
Q23.Resposta04 = "Girafa";
Q23.RespostaCorreta = 02;
ListaQuestoes.Add(Q23);

var Q24 = new Questao();
Q24.pergunta = "Qual é a unidade de medida da força?";
Q24.Resposta01 = "Joule";
Q24.Resposta02 = "Watt";
Q24.Resposta03 = "Newton";
Q24.Resposta04 = "Pascal";
Q24.RespostaCorreta = 03;
ListaQuestoes.Add(Q24);

var Q25 = new Questao();
Q25.pergunta = "Qual é o menor estado brasileiro em área territorial?";
Q25.Resposta01 = "Sergipe";
Q25.Resposta02 = "Alagoas";
Q25.Resposta03 = "Acre";
Q25.Resposta04 = "Espírito Santo";
Q25.RespostaCorreta = 01;
ListaQuestoes.Add(Q25);

var Q26 = new Questao();
Q26.pergunta = "Em que cidade italiana o vulcão Vesúvio está localizado?";
Q26.Resposta01 = "Roma";
Q26.Resposta02 = "Milão";
Q26.Resposta03 = "Nápoles";
Q26.Resposta04 = "Veneza";
Q26.RespostaCorreta = 03;
ListaQuestoes.Add(Q26);

var Q27 = new Questao();
Q27.pergunta = "Quem pintou o teto da Capela Sistina?";
Q27.Resposta01 = "Donatello";
Q27.Resposta02 = "Leonardo da Vinci";
Q27.Resposta03 = "Michelangelo";
Q27.Resposta04 = "Rafael";
Q27.RespostaCorreta = 03;
ListaQuestoes.Add(Q27);

var Q28 = new Questao();
Q28.pergunta = "Qual é a fórmula química do sal de cozinha?";
Q28.Resposta01 = "H2O";
Q28.Resposta02 = "CO2";
Q28.Resposta03 = "NaCl";
Q28.Resposta04 = "KCl";
Q28.RespostaCorreta = 03;
ListaQuestoes.Add(Q28);

var Q29 = new Questao();
Q29.pergunta = "Qual é a capital da Argentina?";
Q29.Resposta01 = "Buenos Aires";
Q29.Resposta02 = "Rosário";
Q29.Resposta03 = "Córdoba";
Q29.Resposta04 = "Mendoza";
Q29.RespostaCorreta = 01;
ListaQuestoes.Add(Q29);

var Q30 = new Questao();
Q30.pergunta = "Qual é o nome da estrela mais próxima da Terra?";
Q30.Resposta01 = "Alpha Centauri";
Q30.Resposta02 = "Proxima Centauri";
Q30.Resposta03 = "Sol";
Q30.Resposta04 = "Betelgeuse";
Q30.RespostaCorreta = 03;
ListaQuestoes.Add(Q30);

var Q31 = new Questao();
Q31.pergunta = "Qual é o maior órgão do corpo humano?";
Q31.Resposta01 = "Coração";
Q31.Resposta02 = "Pulmão";
Q31.Resposta03 = "Fígado";
Q31.Resposta04 = "Pele";
Q31.RespostaCorreta = 04;
ListaQuestoes.Add(Q31);

var Q32 = new Questao();
Q32.pergunta = "Quem inventou o telefone?";
Q32.Resposta01 = "Nikola Tesla";
Q32.Resposta02 = "Alexander Graham Bell";
Q32.Resposta03 = "Thomas Edison";
Q32.Resposta04 = "Isaac Newton";
Q32.RespostaCorreta = 02;
ListaQuestoes.Add(Q32);

var Q33 = new Questao();
Q33.pergunta = "Qual país é conhecido como a Terra do Sol Nascente?";
Q33.Resposta01 = "China";
Q33.Resposta02 = "Japão";
Q33.Resposta03 = "Coreia do Sul";
Q33.Resposta04 = "Filipinas";
Q33.RespostaCorreta = 02;
ListaQuestoes.Add(Q33);

var Q34 = new Questao();
Q34.pergunta = "Qual é o metal cujo símbolo químico é Au?";
Q34.Resposta01 = "Prata";
Q34.Resposta02 = "Ouro";
Q34.Resposta03 = "Alumínio";
Q34.Resposta04 = "Mercúrio";
Q34.RespostaCorreta = 02;
ListaQuestoes.Add(Q34);

var Q35 = new Questao();
Q35.pergunta = "Qual é o nome do maior oceano do mundo?";
Q35.Resposta01 = "Atlântico";
Q35.Resposta02 = "Índico";
Q35.Resposta03 = "Pacífico";
Q35.Resposta04 = "Ártico";
Q35.RespostaCorreta = 03;
ListaQuestoes.Add(Q35);

var Q36 = new Questao();
Q36.pergunta = "Quantos corações tem um polvo?";
Q36.Resposta01 = "Um";
Q36.Resposta02 = "Dois";
Q36.Resposta03 = "Três";
Q36.Resposta04 = "Quatro";
Q36.RespostaCorreta = 03;
ListaQuestoes.Add(Q36);

var Q37 = new Questao();
Q37.pergunta = "Em qual país as pirâmides de Gizé estão localizadas?";
Q37.Resposta01 = "Grécia";
Q37.Resposta02 = "México";
Q37.Resposta03 = "Egito";
Q37.Resposta04 = "Peru";
Q37.RespostaCorreta = 03;
ListaQuestoes.Add(Q37);

var Q38 = new Questao();
Q38.pergunta = "Qual é o maior deserto do mundo?";
Q38.Resposta01 = "Saara";
Q38.Resposta02 = "Kalahari";
Q38.Resposta03 = "Gobi";
Q38.Resposta04 = "Antártida";
Q38.RespostaCorreta = 04;
ListaQuestoes.Add(Q38);

var Q39 = new Questao();
Q39.pergunta = "Qual é o nome do cientista que desenvolveu a teoria da relatividade?";
Q39.Resposta01 = "Isaac Newton";
Q39.Resposta02 = "Albert Einstein";
Q39.Resposta03 = "Galileu Galilei";
Q39.Resposta04 = "Marie Curie";
Q39.RespostaCorreta = 02;
ListaQuestoes.Add(Q39);

var Q40 = new Questao();
Q40.pergunta = "Quem foi o primeiro imperador de Roma?";
Q40.Resposta01 = "Júlio César";
Q40.Resposta02 = "Nero";
Q40.Resposta03 = "Augusto";
Q40.Resposta04 = "Calígula";
Q40.RespostaCorreta= 03;
ListaQuestoes.Add(Q40);

var Q41 = new Questao();
Q41.pergunta = "Qual é o nome do rio que atravessa o Egito?";
Q41.Resposta01 = "Rio Amazonas";
Q41.Resposta02 = "Rio Nilo";
Q41.Resposta03 = "Rio Ganges";
Q41.Resposta04 = "Rio Danúbio";
Q41.RespostaCorreta = 02;
ListaQuestoes.Add(Q41);

var Q42 = new Questao();
Q42.pergunta = "Qual país é famoso por sua Torre de Pisa?";
Q42.Resposta01 = "Espanha";
Q42.Resposta02 = "França";
Q42.Resposta03 = "Itália";
Q42.Resposta04 = "Grécia";
Q42.RespostaCorreta = 03;
ListaQuestoes.Add(Q42);

var Q43 = new Questao();
Q43.pergunta = "Qual animal é conhecido por sua capacidade de mudar de cor para camuflagem?";
Q43.Resposta01 = "Polvo";
Q43.Resposta02 = "Camaleão";
Q43.Resposta03 = "Lula";
Q43.Resposta04 = "Lagartixa";
Q43.RespostaCorreta = 02;
ListaQuestoes.Add(Q43);

var Q44 = new Questao();
Q44.pergunta = "Quem escreveu a peça 'Romeu e Julieta'?";
Q44.Resposta01 = "Charles Dickens";
Q44.Resposta02 = "William Shakespeare";
Q44.Resposta03 = "Mark Twain";
Q44.Resposta04 = "Jane Austen";
Q44.RespostaCorreta = 02;
ListaQuestoes.Add(Q44);

var Q45 = new Questao();
Q45.pergunta = "Qual é o idioma oficial da China?";
Q45.Resposta01 = "Cantonês";
Q45.Resposta02 = "Japonês";
Q45.Resposta03 = "Mandarim";
Q45.Resposta04 = "Coreano";
Q45.RespostaCorreta = 03;
ListaQuestoes.Add(Q45);

var Q46 = new Questao();
Q46.pergunta = "Em qual planeta do sistema solar encontramos o Monte Olimpo, a maior montanha conhecida?";
Q46.Resposta01 = "Terra";
Q46.Resposta02 = "Marte";
Q46.Resposta03 = "Júpiter";
Q46.Resposta04 = "Vênus";
Q46.RespostaCorreta = 02;
ListaQuestoes.Add(Q46);

var Q47 = new Questao();
Q47.pergunta = "Qual foi o primeiro país a ganhar a Copa do Mundo de Futebol?";
Q47.Resposta01 = "Argentina";
Q47.Resposta02 = "Brasil";
Q47.Resposta03 = "Uruguai";
Q47.Resposta04 = "Alemanha";
Q47.RespostaCorreta = 03;
ListaQuestoes.Add(Q47);

var Q48 = new Questao();
Q48.pergunta = "Quem pintou o famoso quadro 'A Noite Estrelada'?";
Q48.Resposta01 = "Claude Monet";
Q48.Resposta02 = "Vincent van Gogh";
Q48.Resposta03 = "Pablo Picasso";
Q48.Resposta04 = "Salvador Dalí";
Q48.RespostaCorreta = 02;
ListaQuestoes.Add(Q48);

var Q49 = new Questao();
Q49.pergunta = "Qual é o nome do órgão responsável por bombear sangue no corpo humano?";
Q49.Resposta01 = "Cérebro";
Q49.Resposta02 = "Fígado";
Q49.Resposta03 = "Coração";
Q49.Resposta04 = "Pulmão";
Q49.RespostaCorreta = 03;
ListaQuestoes.Add(Q49);

var Q50 = new Questao();
Q50.pergunta = "Qual o nome do maior satélite natural da Terra?";
Q50.Resposta01 = "Ganimedes";
Q50.Resposta02 = "Titã";
Q50.Resposta03 = "A Lua";
Q50.Resposta04 = "Europa";
Q50.RespostaCorreta = 03;
ListaQuestoes.Add(Q50);

var Q51 = new Questao();
Q51.pergunta = "Em que ano terminou a Segunda Guerra Mundial?";
Q51.Resposta01 = "1940";
Q51.Resposta02 = "1943";
Q51.Resposta03 = "1945";
Q51.Resposta04 = "1950";
Q51.RespostaCorreta = 03;
ListaQuestoes.Add(Q51);

var Q52 = new Questao();
Q52.pergunta = "Qual país é conhecido como o 'Berço da Civilização'?";
Q52.Resposta01 = "Egito";
Q52.Resposta02 = "Grécia";
Q52.Resposta03 = "China";
Q52.Resposta04 = "Índia";
Q52.RespostaCorreta = 02;
ListaQuestoes.Add(Q52);

var Q53 = new Questao();
Q53.pergunta = "Qual é o principal gás que compõe a atmosfera da Terra?";
Q53.Resposta01 = "Oxigênio";
Q53.Resposta02 = "Dióxido de carbono";
Q53.Resposta03 = "Nitrogênio";
Q53.Resposta04 = "Hidrogênio";
Q53.RespostaCorreta = 03;
ListaQuestoes.Add(Q53);

var Q54 = new Questao();
Q54.pergunta = "Qual o nome do autor de 'A Origem das Espécies', teoria da evolução?";
Q54.Resposta01 = "Charles Darwin";
Q54.Resposta02 = "Isaac Newton";
Q54.Resposta03 = "Albert Einstein";
Q54.Resposta04 = "Galileu Galilei";
Q54.RespostaCorreta = 01;
ListaQuestoes.Add(Q54);

var Q55 = new Questao();
Q55.pergunta = "Quantos continentes existem no mundo?";
Q55.Resposta01 = "Cinco";
Q55.Resposta02 = "Seis";
Q55.Resposta03 = "Sete";
Q55.Resposta04 = "Oito";
Q55.RespostaCorreta = 03;
ListaQuestoes.Add(Q55);

var Q56 = new Questao();
Q56.pergunta = "Qual é o nome do primeiro homem a viajar no espaço?";
Q56.Resposta01 = "Neil Armstrong";
Q56.Resposta02 = "Yuri Gagarin";
Q56.Resposta03 = "Buzz Aldrin";
Q56.Resposta04 = "John Glenn";
Q56.RespostaCorreta = 02;
ListaQuestoes.Add(Q56);

var Q57 = new Questao();
Q57.pergunta = "Qual é o ponto mais alto da Terra?";
Q57.Resposta01 = "Monte Everest";
Q57.Resposta02 = "K2";
Q57.Resposta03 = "Monte Fuji";
Q57.Resposta04 = "Mont Blanc";
Q57.RespostaCorreta = 01;
ListaQuestoes.Add(Q57);

var Q58 = new Questao();
Q58.pergunta = "Qual é o nome do famoso cientista que propôs a teoria da gravitação universal?";
Q58.Resposta01 = "Galileu Galilei";
Q58.Resposta02 = "Albert Einstein";
Q58.Resposta03 = "Isaac Newton";
Q58.Resposta04 = "Nikola Tesla";
Q58.RespostaCorreta = 03;
ListaQuestoes.Add(Q58);

var Q59 = new Questao();
Q59.pergunta = "Qual país é conhecido pela Grande Muralha?";
Q59.Resposta01 = "Japão";
Q59.Resposta02 = "Coreia do Sul";
Q59.Resposta03 = "China";
Q59.Resposta04 = "Vietnã";
Q59.RespostaCorreta = 03;
ListaQuestoes.Add(Q59);

var Q60 = new Questao();
Q60.pergunta = "Qual é o nome do processo pelo qual as plantas produzem seu próprio alimento?";
Q60.Resposta01 = "Fotossíntese";
Q60.Resposta02 = "Respiração celular";
Q60.Resposta03 = "Fermentação";
Q60.Resposta04 = "Quimiossíntese";
Q60.RespostaCorreta = 01;
ListaQuestoes.Add(Q60);

var Q61 = new Questao();
Q61.pergunta = "Quem foi o responsável pela construção do Taj Mahal na Índia?";
Q61.Resposta01 = "Mahatma Gandhi";
Q61.Resposta02 = "Shah Jahan";
Q61.Resposta03 = "Akbar, o Grande";
Q61.Resposta04 = "Jawaharlal Nehru";
Q61.RespostaCorreta = 02;
ListaQuestoes.Add(Q61);

var Q62 = new Questao();
Q62.pergunta = "Qual é a capital da Austrália?";
Q62.Resposta01 = "Sydney";
Q62.Resposta02 = "Melbourne";
Q62.Resposta03 = "Canberra";
Q62.Resposta04 = "Perth";
Q62.RespostaCorreta = 03;
ListaQuestoes.Add(Q62);

var Q63 = new Questao();
Q63.pergunta = "Quem pintou a Mona Lisa?";
Q63.Resposta01 = "Leonardo da Vinci";
Q63.Resposta02 = "Michelangelo";
Q63.Resposta03 = "Vincent van Gogh";
Q63.Resposta04 = "Pablo Picasso";
Q63.RespostaCorreta = 01;
ListaQuestoes.Add(Q63);

var Q64 = new Questao();
Q64.pergunta = "Qual o nome do maior país da América do Sul em extensão territorial?";
Q64.Resposta01 = "Argentina";
Q64.Resposta02 = "Brasil";
Q64.Resposta03 = "Peru";
Q64.Resposta04 = "Colômbia";
Q64.RespostaCorreta = 02;
ListaQuestoes.Add(Q64);

var Q65 = new Questao();
Q65.pergunta = "Qual o nome do escritor francês famoso por 'O Conde de Monte Cristo' e 'Os Três Mosqueteiros'?";
Q65.Resposta01 = "Victor Hugo";
Q65.Resposta02 = "Marcel Proust";
Q65.Resposta03 = "Alexandre Dumas";
Q65.Resposta04 = "Gustave Flaubert";
Q65.RespostaCorreta = 03;
ListaQuestoes.Add(Q65);

var Q66 = new Questao();
Q66.pergunta = "Quantos minutos tem uma hora?";
Q66.Resposta01 = "30";
Q66.Resposta02 = "45";
Q66.Resposta03 = "60";
Q66.Resposta04 = "120";
Q66.RespostaCorreta = 03;
ListaQuestoes.Add(Q66);

var Q67 = new Questao();
Q67.pergunta = "Qual é o menor país do mundo em área territorial?";
Q67.Resposta01 = "Mônaco";
Q67.Resposta02 = "Vaticano";
Q67.Resposta03 = "San Marino";
Q67.Resposta04 = "Liechtenstein";
Q67.RespostaCorreta = 02;
ListaQuestoes.Add(Q67);

var Q68 = new Questao();
Q68.pergunta = "Quantos planetas compõem o Sistema Solar?";
Q68.Resposta01 = "Sete";
Q68.Resposta02 = "Oito";
Q68.Resposta03 = "Nove";
Q68.Resposta04 = "Dez";
Q68.RespostaCorreta = 02;
ListaQuestoes.Add(Q68);

var Q69 = new Questao();
Q69.pergunta = "Qual o país de origem da fabricante de automóveis Toyota?";
Q69.Resposta01 = "Estados Unidos";
Q69.Resposta02 = "Alemanha";
Q69.Resposta03 = "Japão";
Q69.Resposta04 = "Coreia do Sul";
Q69.RespostaCorreta = 03;
ListaQuestoes.Add(Q69);

var Q70 = new Questao();
Q70.pergunta = "Quem foi o fundador do Império Mongol?";
Q70.Resposta01 = "Kublai Khan";
Q70.Resposta02 = "Atilla";
Q70.Resposta03 = "Genghis Khan";
Q70.Resposta04 = "Tamerlão";
Q70.RespostaCorreta = 03;
ListaQuestoes.Add(Q70);

var Q71 = new Questao();
Q71.pergunta = "Qual é o nome do campo de concentração nazista mais famoso?";
Q71.Resposta01 = "Dachau";
Q71.Resposta02 = "Buchenwald";
Q71.Resposta03 = "Auschwitz";
Q71.Resposta04 = "Treblinka";
Q71.RespostaCorreta = 03;
ListaQuestoes.Add(Q71);

var Q72 = new Questao();
Q72.pergunta = "Qual país é famoso por seus moinhos de vento e tulipas?";
Q72.Resposta01 = "Bélgica";
Q72.Resposta02 = "Suíça";
Q72.Resposta03 = "Holanda";
Q72.Resposta04 = "Dinamarca";
Q72.RespostaCorreta = 03;
ListaQuestoes.Add(Q72);

var Q73 = new Questao();
Q73.pergunta = "Quem foi o autor da frase 'Penso, logo existo'?";
Q73.Resposta01 = "Immanuel Kant";
Q73.Resposta02 = "René Descartes";
Q73.Resposta03 = "Friedrich Nietzsche";
Q73.Resposta04 = "Sócrates";
Q73.RespostaCorreta = 02;
ListaQuestoes.Add(Q73);

var Q74 = new Questao();
Q74.pergunta = "Quantas cordas tem um violão padrão?";
Q74.Resposta01 = "Cinco";
Q74.Resposta02 = "Seis";
Q74.Resposta03 = "Sete";
Q74.Resposta04 = "Oito";
Q74.RespostaCorreta =02;
ListaQuestoes.Add(Q74);

var Q75 = new Questao();
Q75.pergunta = "Qual é o país mais populoso do mundo?";
Q75.Resposta01 = "Índia";
Q75.Resposta02 = "Estados Unidos";
Q75.Resposta03 = "Rússia";
Q75.Resposta04 = "China";
Q75.RespostaCorreta = 04;
ListaQuestoes.Add(Q75);

var Q76 = new Questao();
Q76.pergunta = "Qual foi o primeiro homem a pisar na Lua?";
Q76.Resposta01 = "Yuri Gagarin";
Q76.Resposta02 = "Buzz Aldrin";
Q76.Resposta03 = "Neil Armstrong";
Q76.Resposta04 = "Michael Collins";
Q76.RespostaCorreta = 03;
ListaQuestoes.Add(Q76);

var Q77 = new Questao();
Q77.pergunta = "Qual a montanha mais alta da América do Sul?";
Q77.Resposta01 = "Monte Roraima";
Q77.Resposta02 = "Pico da Neblina";
Q77.Resposta03 = "Aconcágua";
Q77.Resposta04 = "Chimborazo";
Q77.RespostaCorreta = 03;
ListaQuestoes.Add(Q77);

var Q78 = new Questao();
Q78.pergunta = "Qual a capital do Canadá?";
Q78.Resposta01 = "Toronto";
Q78.Resposta02 = "Vancouver";
Q78.Resposta03 = "Montreal";
Q78.Resposta04 = "Ottawa";
Q78.RespostaCorreta = 04;
ListaQuestoes.Add(Q78);

var Q79 = new Questao();
Q79.pergunta = "Qual animal é o símbolo da WWF (World Wildlife Fund)?";
Q79.Resposta01 = "Elefante";
Q79.Resposta02 = "Urso Polar";
Q79.Resposta03 = "Panda";
Q79.Resposta04 = "Tigre";
Q79.RespostaCorreta = 03;
ListaQuestoes.Add(Q79);

var Q80 = new Questao();
Q80.pergunta = "Qual elemento químico tem como símbolo a letra 'O'?";
Q80.Resposta01 = "Ouro";
Q80.Resposta02 = "Oxigênio";
Q80.Resposta03 = "Ósmio";
Q80.Resposta04 = "Ouro Branco";
Q80.RespostaCorreta = 02;
ListaQuestoes.Add(Q80);

var Q81 = new Questao();
Q81.pergunta = "Qual país é famoso por suas touradas?";
Q81.Resposta01 = "México";
Q81.Resposta02 = "Portugal";
Q81.Resposta03 = "Espanha";
Q81.Resposta04 = "Itália";
Q81.RespostaCorreta = 03;
ListaQuestoes.Add(Q81);

var Q82 = new Questao();
Q82.pergunta = "Qual é o oceano que banha a costa leste do Brasil?";
Q82.Resposta01 = "Oceano Pacífico";
Q82.Resposta02 = "Oceano Índico";
Q82.Resposta03 = "Oceano Atlântico";
Q82.Resposta04 = "Oceano Ártico";
Q82.RespostaCorreta = 03;
ListaQuestoes.Add(Q82);

var Q83 = new Questao();
Q83.pergunta = "Quem descobriu o Brasil em 1500?";
Q83.Resposta01 = "Cristóvão Colombo";
Q83.Resposta02 = "Pedro Álvares Cabral";
Q83.Resposta03 = "Vasco da Gama";
Q83.Resposta04 = "Américo Vespúcio";
Q83.RespostaCorreta = 02;
ListaQuestoes.Add(Q83);

var Q84 = new Questao();
Q84.pergunta = "Qual o nome do cientista que descobriu a penicilina?";
Q84.Resposta01 = "Alexander Fleming";
Q84.Resposta02 = "Marie Curie";
Q84.Resposta03 = "Louis Pasteur";
Q84.Resposta04 = "Gregor Mendel";
Q84.RespostaCorreta = 01;
ListaQuestoes.Add(Q84);

var Q85 = new Questao();
Q85.pergunta = "Qual é o maior órgão do corpo humano?";
Q85.Resposta01 = "Pulmão";
Q85.Resposta02 = "Fígado";
Q85.Resposta03 = "Pele";
Q85.Resposta04 = "Coração";
Q85.RespostaCorreta = 03;
ListaQuestoes.Add(Q85);

var Q86 = new Questao();
Q86.pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
Q86.Resposta01 = "Abraham Lincoln";
Q86.Resposta02 = "Thomas Jefferson";
Q86.Resposta03 = "George Washington";
Q86.Resposta04 = "John Adams";
Q86.RespostaCorreta = 03;
ListaQuestoes.Add(Q86);

var Q87 = new Questao();
Q87.pergunta = "Qual o maior país do mundo em extensão territorial?";
Q87.Resposta01 = "Canadá";
Q87.Resposta02 = "China";
Q87.Resposta03 = "Rússia";
Q87.Resposta04 = "Estados Unidos";
Q87.RespostaCorreta = 03;
ListaQuestoes.Add(Q87);

var Q88 = new Questao();
Q88.pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
Q88.Resposta01 = "1965";
Q88.Resposta02 = "1969";
Q88.Resposta03 = "1972";
Q88.Resposta04 = "1967";
Q88.RespostaCorreta = 02;
ListaQuestoes.Add(Q88);

var Q89 = new Questao();
Q89.pergunta = "Quem é o autor do livro 'Dom Quixote'?";
Q89.Resposta01 = "Miguel de Cervantes";
Q89.Resposta02 = "Gabriel García Márquez";
Q89.Resposta03 = "Pablo Neruda";
Q89.Resposta04 = "Jorge Luis Borges";
Q89.RespostaCorreta = 01;
ListaQuestoes.Add(Q89);

var Q90 = new Questao();
Q90.pergunta = "Qual é o rio mais longo do mundo?";
Q90.Resposta01 = "Rio Nilo";
Q90.Resposta02 = "Rio Amazonas";
Q90.Resposta03 = "Rio Yangtzé";
Q90.Resposta04 = "Rio Mississippi";
Q90.RespostaCorreta = 02;
ListaQuestoes.Add(Q90);

var Q91 = new Questao();
Q91.pergunta = "Qual é o planeta mais próximo do Sol?";
Q91.Resposta01 = "Terra";
Q91.Resposta02 = "Vênus";
Q91.Resposta03 = "Marte";
Q91.Resposta04 = "Mercúrio";
Q91.RespostaCorreta = 04;
ListaQuestoes.Add(Q91);

var Q92 = new Questao();
Q92.pergunta = "Em que continente fica o Egito?";
Q92.Resposta01 = "Ásia";
Q92.Resposta02 = "Europa";
Q92.Resposta03 = "África";
Q92.Resposta04 = "América do Sul";
Q92.RespostaCorreta = 03;
ListaQuestoes.Add(Q92);

var Q93 = new Questao();
Q93.pergunta = "Quantos lados tem um triângulo?";
Q93.Resposta01 = "Dois";
Q93.Resposta02 = "Três";
Q93.Resposta03 = "Quatro";
Q93.Resposta04 = "Cinco";
Q93.RespostaCorreta = 02;
ListaQuestoes.Add(Q93);

var Q94 = new Questao();
Q94.pergunta = "Qual é a capital da França?";
Q94.Resposta01 = "Berlim";
Q94.Resposta02 = "Madri";
Q94.Resposta03 = "Paris";
Q94.Resposta04 = "Londres";
Q94.RespostaCorreta = 03;
ListaQuestoes.Add(Q94);

var Q95 = new Questao();
Q95.pergunta = "Quem pintou 'O Grito'?";
Q95.Resposta01 = "Salvador Dalí";
Q95.Resposta02 = "Edvard Munch";
Q95.Resposta03 = "Pablo Picasso";
Q95.Resposta04 = "Claude Monet";
Q95.RespostaCorreta = 02;
ListaQuestoes.Add(Q95);

var Q96 = new Questao();
Q96.pergunta = "Qual é a moeda oficial do Japão?";
Q96.Resposta01 = "Euro";
Q96.Resposta02 = "Dólar";
Q96.Resposta03 = "Iene";
Q96.Resposta04 = "Yuan";
Q96.RespostaCorreta = 03;
ListaQuestoes.Add(Q96);

var Q97 = new Questao();
Q97.pergunta = "Quem é o autor de 'A Divina Comédia'?";
Q97.Resposta01 = "Dante Alighieri";
Q97.Resposta02 = "William Shakespeare";
Q97.Resposta03 = "Homer";
Q97.Resposta04 = "Virgílio";
Q97.RespostaCorreta = 01;
ListaQuestoes.Add(Q97);

var Q98 = new Questao();
Q98.pergunta = "Quantos ossos tem o corpo humano adulto?";
Q98.Resposta01 = "206";
Q98.Resposta02 = "208";
Q98.Resposta03 = "210";
Q98.Resposta04 = "212";
Q98.RespostaCorreta = 01;
ListaQuestoes.Add(Q98);

var Q99 = new Questao();
Q99.pergunta = "Em qual cidade estão localizadas as pirâmides de Gizé?";
Q99.Resposta01 = "Cairo";
Q99.Resposta02 = "Luxor";
Q99.Resposta05 = "Sumatra";
Q99.Resposta03 = "Alexandria";
Q99.Resposta04 = "Assuã";
Q99.RespostaCorreta = 01;
ListaQuestoes.Add(Q99);

    }
      public void ProximaQuestao()
      {
        var NumRandomico = Random.Shared.Next(0,ListaQuestoes.Count);
        while(ListaQuestoesRespondidas.Contains(NumRandomico))
         NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count);
         ListaQuestoesRespondidas.Add(NumRandomico);
         QuestaoCorrente = ListaQuestoes[NumRandomico];
         QuestaoCorrente.Desenhar();
      }
      
      public async void VerificaResposta(int rr)
      {
        if(QuestaoCorrente.VerificaResposta(rr))
        {
         await Task.Delay(1000);
         ProximaQuestao();
        }
      }
}