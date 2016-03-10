using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Encadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;
        private int valor, p, v, a, b;


        public Form1()
        {
            InitializeComponent();
            lista = new Lista();
        }


        private void Valores(object sender, EventArgs e)
        {
            valor = Convert.ToInt32(Setador.Text);

            Unidade item = new Unidade(valor);

            if (posicao.Enabled)
            {
                p = Convert.ToInt32(posicao.Text);
                lista.IncorporaNaListaPorPosicao(item, p);
                listando.Text += "Valor " + p + ": " + item.ComoPalavra;
            }
            if(valorBox.Enabled)
            {
                v = Convert.ToInt32(valorBox.Text);
                lista.IncorporaNaListaPorValor(item, v);
                listando.Text += "Valor "  + ": " + item.ComoPalavra;
            }
            else
            {
                lista.Incorpora(item);
                listando.Text += "Valor " + lista.Contante.ToString() + ": " + item.ComoPalavra;
            }

            listando.Text = "";
            for (int i = 1; i <= lista.Contante; i++)
            {
                listando.Text += "Valor " + i + ": " + lista.BuscaPorPosicao(i).ComoPalavra;
            }
        }

        private void PorPosicao(object sender, EventArgs e)
        {
            posicao.Enabled = true;
        }

        private void ZerarValor(object sender, EventArgs e)
        {
            Setador.Text = null;
        }

        private void ZerarPosicao(object sender, EventArgs e)
        {
            posicao.Text = null;
        }

        private void PorValor(object sender, EventArgs e)
        {
            valorBox.Enabled = true;
        }

        private void ZerarPorValor(object sender, EventArgs e)
        {
            valorBox.Text = null;
        }


        private void ZerarPosicao1(object sender, EventArgs e)
        {
            TrocarPosicao1.Text = null;
        }

        private void ZerarPosicao2(object sender, EventArgs e)
        {
            TrocarPosicao2.Text = null;
        }

        private void TrocarEntrePosicoes(object sender, EventArgs e)
        {
            TrocarPosicao1.Enabled = true;
            TrocarPosicao2.Enabled = true;
        }
    }
}
