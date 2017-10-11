using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleton; // On creer l'objet singleton en private pour qu'il ne soit utiliser que dans cette classe


        public static Singleton CreerSingleton() // On met public pour pouvoir l'appeler ailleur
        {
            if (singleton == null) // On test si c'est null pour pouvoir l'instancier
            {
                singleton = new Singleton(); // On l'instancie
                return singleton;
            }
            else
            {
                return singleton; // On retourne singleton car c'est toujours le même objet qu'on veut.
            }
            
        }

        private Singleton () // On creer une methode vide en private pour ne plus pouvoir l'instancier de cette manière "Singleton s1 = new Singleton()"
        {

        }
    }
}
