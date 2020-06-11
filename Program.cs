using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;      //Digunakan untuk Abstract Class
using Abstraction.Interface;            //Digunakan untuk Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANGUN DATAR");
            Console.WriteLine();

            //BangunDatar bangundatar;  //Digunakan untuk Abstract Class
            IBangunDatar bangundatar;   //Digunakan untuk Interface

            Console.WriteLine("1. Persegi");
            bangundatar = new Persegi();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.WriteLine();
            Console.WriteLine("2. Jajar Genjang");
            bangundatar = new PersegiPanjang();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.WriteLine();
            Console.WriteLine("3. Segitiga");
            bangundatar = new Segitiga();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.ReadKey(true);
        }
    }
}
