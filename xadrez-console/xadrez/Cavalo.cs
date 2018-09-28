using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez {
    class Cavalo : Peca {

        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) {

        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            // nordeste opcao1
            pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha - 2, pos.coluna + 1);
            }

            // nordeste opcao2
            pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha - 2, pos.coluna + 1);
            }


            // sudeste opca1
            pos.definirValores(posicao.linha + 2, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 2, pos.coluna + 1);
            }

            // sudeste opca2
            pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna + 2);
            }

            // Noroeste opca1
            pos.definirValores(posicao.linha - 2, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha - 2, pos.coluna - 1);
            }

            // Noroeste opca2
            pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna - 2);
            }

            // Sudoeste opca1
            pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 2, pos.coluna - 1);
            }

            // Sudoeste opca2
            pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna - 2);
            }

            return mat;
        }

        public override string ToString() {
            return "C";
        }
    }
}
