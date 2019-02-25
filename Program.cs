using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_53_Constructor_yapıcı_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {

                string ad,soyad,sinif,ders;
                Console.Write("ADI:");
                ad = Console.ReadLine();

                Console.Write("SOYAD:");
                soyad = Console.ReadLine();

                Console.Write("DERS:");
                ders = Console.ReadLine();

                Console.Write("SINIF:");
                sinif = Console.ReadLine();

                Console.WriteLine("/n/n/n");
                ogrenci ogr = new ogrenci(ad,soyad,ders,sinif );
                Console.Read();

            }
        }
    }
}
