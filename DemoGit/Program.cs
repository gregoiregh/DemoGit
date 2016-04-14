using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Toto", 20);
            Console.WriteLine(p1);
            Personne p2 = new Personne();
            Console.WriteLine(p2);

            Personne p3 = new Salarie();
            Console.WriteLine(p3);

            Console.ReadKey();
        }
    }
    }
}
