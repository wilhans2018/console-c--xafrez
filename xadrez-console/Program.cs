﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            Posicao posicao = new Posicao(3, 4);

            Console.WriteLine(posicao);
            Console.ReadLine();
        }
    }
}
