using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Encadeada
{
    class Lista
    {
        private Unidade primogenita;

        public Unidade Primogenita
        {
            get
            {
                return primogenita;
            }
            set
            {
                primogenita = value;
            }
        }

        public Unidade Cacula
        {
            get
            {
                return BuscaCacula();
            }
        }

        public void Incorpora(Unidade u)
        {
            if(Primogenita == null)
            {
                Primogenita = u;
            }
            else
            {
                Cacula.Proxima = u;
            }
        }

        public void IncorporaNaListaPorPosicao(Unidade u, int p)
        {
            Unidade aux = BuscaPorPosicao(p - 1);

            u.Proxima = aux.Proxima;
            aux.Proxima = u;
        }

        public void IncorporaNaListaPorValor(Unidade u, int v)
        {
            Unidade aux = BuscaPorValor(v);
            u.Proxima = aux.Proxima;
            aux.Proxima = u;
        }

 


        public Unidade BuscaCacula()
        {
            Unidade aux = Primogenita;
            
            while(aux.Proxima != null)
            {
                aux = aux.Proxima;
            }
            return aux;
        }

        public int Contante
        {
            get
            {
                int contante = 0;
                Unidade aux = Primogenita;

                while(aux != null)
                {
                    aux = aux.Proxima;
                    contante++;
                }
                return contante;
            } 
        }

        public Unidade BuscaPorPosicao(int p)
        {
            int contante = 1;            
            Unidade aux = Primogenita;

            while (contante < p)
            {
                aux = aux.Proxima;
                contante++;
            }
            return aux;
        }

        public Unidade BuscaPorValor(int v)
        {
            Unidade aux = Primogenita;
            int contante = 1;

            while(aux.Valor != v)
            {
                aux = aux.Proxima;
                contante++;
            }
            return aux;
        }

        public int BuscaPosicao(int v, int condicao)
        {
            Unidade aux = Primogenita;
            int contante = 1;

            while (v != condicao)
            {
                aux = aux.Proxima;
                contante++;
            }
            return contante;
        }

        /// <summary>
        /// Para qualquer bug que der, conferir por aqui :)
        /// </summary>
        public void Print()
        {
            Unidade bonito = Primogenita;
            while(bonito != null)
            {
                Console.WriteLine(bonito.Valor);
                bonito = bonito.Proxima;
            }
        }


    }
}
