/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// tu ukážem použitie polymorfizmu

namespace EELC
{
    class Zvieratko // parent classa Zvieratko
    {
        public virtual void vydajzvuk() // virtual = metódu je možné prepísať v child classe
        {
            Console.WriteLine("Zviera vydava zvuk");
        }
    }

    class Prasiatko : Zvieratko // child classa Prasiatko
    {
        public override void vydajzvuk() // override = vyžadované pri prepisovaní virtual metódy vydajzvuk()
        {
            Console.WriteLine("Prasa robi kvik - kvik");
        }
    }

    class Psik : Zvieratko // child classa Psik
    {
        public override void vydajzvuk()
        {
            Console.WriteLine("Pes robi hau - hau");
        }
    }

    class MojPolymorfizmus
    {
        static void Main(string[] args)
        {
            Zvieratko zvieratko = new Zvieratko();
            Zvieratko prasiatko = new Prasiatko();
            Zvieratko havko = new Psik(); 

            zvieratko.vydajzvuk();
            prasiatko.vydajzvuk();
            havko.vydajzvuk();
        }
    }
}*/
