using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class Lista<T>
    {
        /* Lembrando que estamos trabalhando com listas em uma linguagem de maior nível se comparado ao C,
        o c# não trabalha com dados estruturados, mas sim com objetos.*/


        public T Nome { get; set; }
        public T Chave { get; set; }
        public Lista<T> Prox { get; set; }
    }
}
