/*
 * Projeto Xadrez
 * Professor Nélio Alves - Udemy
 * Aluno Douglas Rosemann
 * Data Inicio: 25/05/2020
 * Data Fim: xx/05/2020
 */
using System;
using tabuleiro;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
