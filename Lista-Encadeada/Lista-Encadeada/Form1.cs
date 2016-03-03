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
        private int valor;
        //private int setPosicao;
        private int p;

        public Form1()
        {
            InitializeComponent();
            lista = new Lista();
        }


        private void Valores(object sender, EventArgs e)
        {
            valor = Convert.ToInt32(Setador.Text);

            Unidade item = new Unidade(valor), aux;

            if (posicao.Enabled)
            {
                p = Convert.ToInt32(posicao.Text);
                lista.IncorporaNaLista(item, p);
                listando.Text += "Valor " + p + ": " + item.ComoPalavra;
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
    }
}
