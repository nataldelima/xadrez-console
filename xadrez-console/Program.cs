﻿using tabuleiro;
using tabuleiro.xadrez;

namespace xadrez_console;

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
                Tela.imprimirTabuleiro(partida.tab);
                Console.WriteLine();
                Console.WriteLine();
                
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                
                partida.ExecutaMovimento(origem, destino);
                
            }

            Tela.imprimirTabuleiro(partida.tab);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}