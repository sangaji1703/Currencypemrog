using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;    
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kendaraan kendaraan;          
            kendaraan = new Mobil();
            kendaraan.Jenis();

            Console.WriteLine();
            kendaraan = new Motor();
            kendaraan.Jenis();

            Console.WriteLine();
            kendaraan = new Sepeda();
            kendaraan.Jenis();

            Console.ReadKey();
        }
    }
}