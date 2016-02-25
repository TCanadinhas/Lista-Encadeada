using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Encadeada
{
    class Unidade
    {
        #region Propriedades

        private int valor;
        private Unidade proxima;
        private Unidade anterior;
        
        #endregion

        #region Método

        public Unidade(int v, Unidade p = null, Unidade a = null)
        {
            Valor = v;
            Proxima = p;
            Anterior = a;
        }

        #endregion

        #region Get/Set

        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value; 
            }
        }

        public Unidade Proxima
        {
            get
            {
                return proxima;
            }
            set
            {
                proxima = value;
            }
        }

        public Unidade Anterior
        {
            get
            {
                return anterior;
            }
            set
            {
                anterior = value;
            }
        }

        #endregion

        #region String
        public String ComoPalavra
        {
            get
            {
                return valor.ToString() + " \n"; 
            }
        }
        #endregion
    }
}
