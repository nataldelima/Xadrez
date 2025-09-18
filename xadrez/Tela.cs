using System.Globalization;

namespace xadrez;

using tabuleiro;

public class Tela
{
    public static void imprimirPartida(PartidaDeXadrez partida)
    {
        imprimirTabueiro(partida.tab);
        Console.WriteLine();
        imprimirPecasCapturadas(partida);
        Console.WriteLine($"\n\nTurno: {partida.turno}");
        Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");
        if (partida.xeque)
        {
            Console.WriteLine("XEQUE!");
        }
    }
    public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
    {
        Console.WriteLine("Peças capturadas:");
        Console.Write("\nBrancas: ");
        imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
        Console.Write("\nPretas: ");
        ConsoleColor aux = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
        Console.ForegroundColor = aux;
    }

    public static void imprimirConjunto(HashSet<Peca> conjunto)
    {
        Console.Write("[");
        foreach (Peca x in conjunto)
        {
            Console.Write($"{x} ");
        }
        Console.Write("]");
    }
    public static void imprimirTabueiro(Tabuleiro tab)
    {
        for (int i = 0; i < tab.linhas; i++)
        {
            Console.Write($"{8 - i} ");
            for (int j = 0; j < tab.colunas; j++)
            {
                imprimirPeca(tab.peca(i, j));
            }

            Console.WriteLine();
        }

        Console.Write("  A B C D E F G H");
    }
    
    public static void imprimirTabueiro(Tabuleiro tab, bool[,] posicoesPossiveis)
    {
        ConsoleColor fundoOriginal = Console.BackgroundColor;
        ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
        for (int i = 0; i < tab.linhas; i++)
        {
            Console.Write($"{8 - i} ");
            for (int j = 0; j < tab.colunas; j++)
            {
                if (posicoesPossiveis[i, j])
                {
                    Console.BackgroundColor = fundoAlterado;
                }
                else
                {
                    Console.BackgroundColor = fundoOriginal;
                }
                imprimirPeca(tab.peca(i, j));
                Console.BackgroundColor = fundoOriginal;
            }

            Console.WriteLine();
        }

        Console.Write("  A B C D E F G H");
        Console.ForegroundColor = fundoOriginal;
    }

    public static PosicaoXadrez lerPosicaoXadrex()
    {
        string s = Console.ReadLine();
        char coluna = s[0];
        int linha = int.Parse(s[1] + "");
        return new PosicaoXadrez(coluna, linha);
    }

    public static void imprimirPeca(Peca peca)
    {
        if (peca == null)
        {
            Console.Write("- ");
        }
        else
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }

            Console.Write(" ");
        }
    }
}