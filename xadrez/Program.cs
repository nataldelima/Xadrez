using tabuleiro;
using xadrez;

namespace xadrez;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while (!partida.terminada)
            {
                Console.Clear();
                Tela.imprimirTabueiro(partida.tab);
                
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Origem:  ");
                Posicao origem = Tela.lerPosicaoXadrex().toPosicao();
                
                Console.Write("Destino:  ");
                Posicao destino = Tela.lerPosicaoXadrex().toPosicao();
                
                partida.ExecutaMovimento(origem, destino);
            }
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}