using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListaDinamica<string> lista = new ListaDinamica<string>();
            //String
            Hash<string> hash = new Hash<string>();


            hash.add("Maria", "Namorada Pedro");
            hash.add("Pedro", "Namorado de Maria");
            hash.add("Ana", "minha mãe");
            hash.add("Maria", "Namorada de pedro");
            hash.add("João", "Tio joão");
            hash.add("Pedro", "Namorada de Augusto");
            hash.add("airaM", "Maria ao contrário");


            hash.dictionary[hash.funcaoHashColisao("Maria")].imprimeLista();
            hash.dictionary[hash.funcaoHashColisao("airaM")].imprimeLista();

            // Com números
            //Hash<int> hash = new Hash<int>();
            //hash.add(1, 11);
            //hash.add(2, 22);
            //hash.add(3, 33);
            //hash.add(4, 44);
            //hash.add(5, 55);
            //hash.add(6, 66);
            //hash.add(5, 99);

            //Console.WriteLine(hash.existe(33));
            //hash.dictionary[hash.funcaoHashColisao(1)].imprimeLista();
            //hash.dictionary[hash.funcaoHashColisao(5)].imprimeLista();



            Console.ReadKey();

        }
    }
}
