using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static int[] ammo;
        static void Main(string[] args)
        {
            ammo = new int[2];
            ammo[0] = 1;
            ammo[1] = 2;

            Console.WriteLine(ammo[0]);
            Console.ReadKey();
        }
        static void Fire()
        {

        }
        static void Reload()
        {

        }
    }
}
