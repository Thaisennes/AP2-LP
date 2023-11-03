class Jogador
{
    Random random = new Random();
    public string? Nome;
    public string? Nickname;
    public int Pontos = 0;

    public void Jogar()
    {
        Pontos = random.Next(1, 101);
    }
}