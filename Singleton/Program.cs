using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton thon = new Singleton();
            //Singleton mayo = new Singleton();
            Singleton salade = Singleton.CreerSingleton();
            Singleton thon = Singleton.CreerSingleton();

            Console.WriteLine(thon.Equals(salade));
            Console.ReadKey();
        }
    }
}
