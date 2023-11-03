class Campeonato
{
    public string NomeCampeonato;
    public Equipe Equipe1;
    public Equipe Equipe2;

    public void IniciarPartida(Equipe e1, Equipe e2)
    {
        e1.j1.Jogar();
        e1.j2.Jogar();
        e1.j3.Jogar();
        e1.j4.Jogar();
        e1.j5.Jogar();

        e2.j1.Jogar();
        e2.j2.Jogar();
        e2.j3.Jogar();
        e2.j4.Jogar();
        e2.j5.Jogar();
    }
    public void Classificacao()
    {
        if (Equipe1.PontosTotal() > Equipe2.PontosTotal())
        {
            Console.WriteLine($"\n1. {Equipe1.NomeEquipe}\nPontos: {Equipe1.PontosTotal()}\n");
            Console.WriteLine($"{Equipe1.j1.Nickname}: {Equipe1.j1.Pontos} pontos");
            Console.WriteLine($"{Equipe1.j2.Nickname}: {Equipe1.j2.Pontos} pontos");
            Console.WriteLine($"{Equipe1.j3.Nickname}: {Equipe1.j3.Pontos} pontos");
            Console.WriteLine($"{Equipe1.j4.Nickname}: {Equipe1.j4.Pontos} pontos");
            Console.WriteLine($"{Equipe1.j5.Nickname}: {Equipe1.j5.Pontos} pontos");

            Console.WriteLine($"\n2. {Equipe2.NomeEquipe}\nPontos: {Equipe2.PontosTotal()}\n");
            Console.WriteLine($"{Equipe2.j1.Nickname}: {Equipe2.j1.Pontos} pontos");
            Console.WriteLine($"{Equipe2.j2.Nickname}: {Equipe2.j2.Pontos} pontos");
            Console.WriteLine($"{Equipe2.j3.Nickname}: {Equipe2.j3.Pontos} pontos");
            Console.WriteLine($"{Equipe2.j4.Nickname}: {Equipe2.j4.Pontos} pontos");
            Console.WriteLine($"{Equipe2.j5.Nickname}: {Equipe2.j5.Pontos} pontos");

            Console.WriteLine($"\n{Equipe1.NomeEquipe} venceu!");
        }
        else {
            Console.WriteLine($"\n2. {Equipe2.NomeEquipe}\nPontos: {Equipe2.PontosTotal()}\n");
            Console.WriteLine($"{Equipe2.j1.Nickname}: {Equipe2.j1.Pontos} pontos");
            Console.WriteLine($"{Equipe2.j2.Nickname}: {Equipe2.j2.Pontos} pontos");
            Console.WriteLine($"{Equipe2.j3.Nickname}: {Equipe2.j3.Pontos} pontos");
            Console.WriteLine($"{Equipe2.j4.Nickname}: {Equipe2.j4.Pontos} pontos");
            Console.WriteLine($"{Equipe2.j5.Nickname}: {Equipe2.j5.Pontos} pontos");

            Console.WriteLine($"\n1. {Equipe1.NomeEquipe}\nPontos: {Equipe1.PontosTotal()}\n");
            Console.WriteLine($"{Equipe1.j1.Nickname}: {Equipe1.j1.Pontos} pontos");
            Console.WriteLine($"{Equipe1.j2.Nickname}: {Equipe1.j2.Pontos} pontos");
            Console.WriteLine($"{Equipe1.j3.Nickname}: {Equipe1.j3.Pontos} pontos");
            Console.WriteLine($"{Equipe1.j4.Nickname}: {Equipe1.j4.Pontos} pontos");
            Console.WriteLine($"{Equipe1.j5.Nickname}: {Equipe1.j5.Pontos} pontos");

            Console.WriteLine($"\n{Equipe2.NomeEquipe} venceu!");
        }
    }
}