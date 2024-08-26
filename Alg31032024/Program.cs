using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Alg31032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A kisi class will be created.  There will be objects in this kisi class that can hold id, name and surname data. 
            // An array will be created from this kisi class. Then this data will be printed on the screen.
            kisi k1 = new kisi();
            k1.id = 1;
            k1.ad = "niloya";
            k1.soyad = "bahçe";
            kisi k2 = new kisi();
            k2.id = 2;
            k2.ad = "seray";
            k2.soyad = "bahçe";
            kisi k3 = new kisi();
            k3.id = 3;
            k3.ad = "milay";
            k3.soyad = "bahçe";

            List<kisi> kisilerim = new List<kisi>();
            kisilerim.Add(k1);
            kisilerim.Add(k2);
            kisilerim.Add(k3);

            for (int i = 0; i < kisilerim.Count; i++)
            {
                Console.WriteLine(kisilerim[i].id);
                Console.WriteLine(kisilerim[i].ad);
                Console.WriteLine(kisilerim[i].soyad);
            }

            Console.ReadKey();

        }
    }
}
