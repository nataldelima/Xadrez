namespace tabuleiro;

public abstract class Peca
{
    public Posicao posicao { get; set; }
    public Cor cor { get; protected set; }
    public int qtdMovimentos { get; protected set; }
    public Tabuleiro tab { get; set; }

    public Peca(Cor cor, Tabuleiro tab)
    {
        this.posicao = null;
        this.cor = cor;
        this.tab = tab;
        this.qtdMovimentos = 0;
    }

    public abstract bool [,] movimentosPossiveis();
    public void incrementarQteMovimentos()
    {
        qtdMovimentos++;
    }
}