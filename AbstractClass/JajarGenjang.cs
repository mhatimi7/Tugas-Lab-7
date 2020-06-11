using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class JajarGenjang : BangunDatar
    {
        public int a,t,s;

        public override void Luas()
        {
            Console.Write("Masukkan nilai alas    = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai tinggi     = ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai sisi       = ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Jajar Genjang      = " + (a * t));
        }

        public override void Keliling()
        {
            Console.WriteLine("Keliling Jajar Genjang  = " + (s + s + s + s));
        }
    }
}
