Jogador j1 = new Jogador();
j1.Nome = "Hermione Granger";
j1.Nickname = "Granger";

Jogador j2 = new Jogador();
j2.Nome = "Harry Potter";
j2.Nickname = "Potter";

Jogador j3 = new Jogador();
j3.Nome = "Ron Weasley";
j3.Nickname = "Ron";

Jogador j4 = new Jogador();
j4.Nome = "Rúbeo Hagrid";
j4.Nickname = "Hagrid";

Jogador j5 = new Jogador();
j5.Nome = "Neville Longbottom";
j5.Nickname = "Longbottom";

Jogador j6 = new Jogador();
j6.Nome = "Draco Malfoy";
j6.Nickname = "Malfoy";

Jogador j7 = new Jogador();
j7.Nome = "Severo Snape";
j7.Nickname = "Snape";

Jogador j8 = new Jogador();
j8.Nome = "Horácio Slughorn";
j8.Nickname = "Horácio";

Jogador j9 = new Jogador();
j9.Nome = "Vicente Crabbe";
j9.Nickname = "Crabbe";

Jogador j10 = new Jogador();
j10.Nome = "Gregório Goyle";
j10.Nickname = "Goyle";

Equipe e1 = new Equipe();
e1.NomeEquipe = "Grifinória";
e1.AdicionarJogador(j1);
e1.AdicionarJogador(j2);
e1.AdicionarJogador(j3);
e1.AdicionarJogador(j4);
e1.AdicionarJogador(j5);

Equipe e2 = new Equipe();
e2.NomeEquipe = "Sonserina";
e2.AdicionarJogador(j6);
e2.AdicionarJogador(j7);
e2.AdicionarJogador(j8);
e2.AdicionarJogador(j9);
e2.AdicionarJogador(j10);

string continuar;

do {
    Campeonato Campeonato = new Campeonato();
    Campeonato.Equipe1 = e1;
    Campeonato.Equipe2 = e2;

    Campeonato.Equipe1.j1.Jogar();
    Campeonato.Equipe1.j2.Jogar();
    Campeonato.Equipe1.j3.Jogar();
    Campeonato.Equipe1.j4.Jogar();
    Campeonato.Equipe1.j5.Jogar();

    Campeonato.Equipe2.j1.Jogar();
    Campeonato.Equipe2.j2.Jogar();
    Campeonato.Equipe2.j3.Jogar();
    Campeonato.Equipe2.j4.Jogar();
    Campeonato.Equipe2.j5.Jogar();

    Campeonato.Classificacao();

    Console.WriteLine("\nGerar uma nova partida? (s/n)\n");
    continuar = Console.ReadLine().ToLower();

} while (continuar == "s");
Console.WriteLine("\nCampeonato finalizado.\n");