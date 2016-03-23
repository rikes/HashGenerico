using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class ListaDinamica<T> : IEnumerable
    {
        public Lista<T> Primeiro;
        public Lista<T> Ultimo;
        public Lista<T> No;
        public int tamanho;
        public ListaDinamica<T> ProxDinamica { get; set; }

        public ListaDinamica( )
        {
            Primeiro = null;
            Ultimo = Primeiro;
            this.tamanho = 0;
        }

        //Métodos de operações.
        /*Lembrando que, o Prox* só guarda a referencia do objeto(No)
        Enquanto uma Lista(No,ult,prim) guarda o item e a referencia do prox
        */
        public void Add(T chave,T item)
        {
            //Lista vazia
            if (Primeiro == null)
            {
                this.Primeiro = new Lista<T>();
                Ultimo = Primeiro;
                No = new Lista<T>();
                No.Chave = chave;
                No.Nome = item;
                //Andando na lista, a linha seguinte não é necessária.
                //No.Prox = null;
                Primeiro.Prox = No;//Poderia ser só, estamos mudandoa  referencia, Ultimo.Prox = No; 
                Ultimo = No; 
                this.tamanho++;
            }
            else
            {
                No = new Lista<T>();
                No.Chave = chave;
                No.Nome = item;
                //Andando na lista
                No.Prox = null;
                Ultimo.Prox = No;
                Ultimo = No;
                this.tamanho++;
            }
        }

        public void removeLista(T item)
        {
            if (Primeiro != null)
            {
                Lista<T> no = Primeiro.Prox;
                Lista<T> aux = Primeiro;

                while (no != null)
                {
                    if (igual(no.Chave,item))
                    {
                        if (no.Prox == null) //Ultimo elemento
                        {
                            this.Ultimo = aux;
                            this.Ultimo.Prox = null;
                            no = this.Ultimo;
                            tamanho--;
                        }
                        else
                        {
                            aux.Prox = no.Prox;
                            no = null;
                            no = aux.Prox;
                            tamanho--;
                        }

                    }
                    no = no.Prox;
                    aux = aux.Prox;
                }
            }
        }

        public bool existe(T chave)
        {
            if (Primeiro != null)
            {
                Lista<T> no = Primeiro.Prox;
                //Lista<T> aux = Primeiro;
                while (no != null)
                {
                    if (igual(no.Chave, chave))
                        return true;
                    no = no.Prox;
                    //aux = aux.Prox;
                }
            }
            return false;
        }



        public void imprimeLista()
        {
            if (Primeiro != null)
            {
                Lista<T> no = Primeiro.Prox;
                while (no != null)
                {
                    Console.WriteLine("Chave {0}",no.Chave);
                    Console.WriteLine("Valor {0} \n",no.Nome);
                    no = no.Prox;

                }
            }
        }

        public bool igual(T item1, T item2)
        {
            return EqualityComparer<T>.Default.Equals(item1, item2);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
    }
}
