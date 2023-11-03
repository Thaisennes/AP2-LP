class Equipe
{
    public string? NomeEquipe;
    public Jogador j1;
    public Jogador j2;
    public Jogador j3;
    public Jogador j4;
    public Jogador j5;

    public int PontosTotal()
    {
        return j1.Pontos + j2.Pontos + j3.Pontos + j4.Pontos + j5.Pontos;
    }
    public void AdicionarJogador(Jogador j)
    {
        if (j1 == null)
        {
            j1 = j;
        }
        else if (j2 == null)
        {
            j2 = j;
        }
        else if (j3 == null)
        {
            j3 = j;
        }
        else if (j4 == null)
        {
            j4 = j;
        }
        else if (j5 == null)
        {
            j5 = j;
        } else {
            Console.WriteLine("Equipe completa");
        }
    }
}