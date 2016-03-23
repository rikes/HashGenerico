using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class Hash<T> 
    {
        //Usaremos vetor de listas
        public ListaDinamica<T>[] dictionary;
        
        public Hash()
        {
            this.dictionary = new ListaDinamica<T>[127];
            for (int i = 0; i < dictionary.Length; i++)
            {
                dictionary[i] = new ListaDinamica<T>();
            }
        }
        

        private int funcaoHash(T chave)
        {
            int hash = 0;
            hash = chave.GetHashCode();
            return hash;
        }

        public int funcaoHashColisao(T chave)
        {

            string chaveString = chave.ToString();
            byte[] key =  Encoding.ASCII.GetBytes(chaveString);
            return key[0];
        }

        public void add(T chave, T item)
        {
            dictionary[funcaoHashColisao(chave)].Add(chave,item);
        }

        public bool existe(T chave)
        {
            //return dictionary.Any(t => t.igual(t.No.Chave, chave));

            return dictionary.Any(t => t.No != null && t.igual(t.No.Chave, chave));

            /*for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i].No != null && dictionary[i].igual(dictionary[i].No.Chave, chave))
                    return true;
            }
            return false;*/
        }

    }
}
