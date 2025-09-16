﻿using tabuleiro;
using xadrez;

namespace xadrez;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(Cor.Preta, tab),new Posicao(0,0));
            tab.colocarPeca(new Rei(Cor.Preta, tab),new Posicao(0,2));
            tab.colocarPeca(new Torre(Cor.Preta, tab),new Posicao(1,9));
            tab.colocarPeca(new Rei(Cor.Preta, tab),new Posicao(2,4));
        
            Tela.imprimirTabueiro(tab);

        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
        
       
    }
}