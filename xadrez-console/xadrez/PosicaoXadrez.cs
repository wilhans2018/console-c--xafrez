﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez {
    class PosicaoXadrez {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}
