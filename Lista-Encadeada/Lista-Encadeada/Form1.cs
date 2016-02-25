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

        public Form1()
        {
            InitializeComponent();
            lista = new Lista(); 
        }


        private void Valores(object sender, EventArgs e)
        {
            valor = Convert.ToInt16(Setador.Text);
            Unidade item = new Unidade(valor);

            lista.Incorpora(item);
            //listando.Text += "Valor: " + item.ComoPalavra;
            listando.Text += "Valor " + lista.Contante.ToString() + ": " + item.ComoPalavra;
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
