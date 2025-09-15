using tabuleiro;

namespace xadrez;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8, 8);
        Console.WriteLine($"Tabuleiro {tab.linhas}x{tab.colunas}");
        
    }
}