using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_01_25_Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fuvar> fuvarok = new List<Fuvar>();
            foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }
            Console.WriteLine($"3.feladat: {fuvarok.Count} fuvar");

            //4. 
            int db = 0;
            double bevétel = 0; 
            foreach (var f in fuvarok)
            {
                if (f.TaxiID == 6185)
                {
                    db++;
                    bevétel += f.Viteldíj + f.Borravaló;
                }
            }
            Console.WriteLine($"4.feladat: {db} fuvar alatt: {bevétel}$");

            //5.
            int bankkártya = 0;
            int készpénz = 0;
            int vitatott = 0;
            int ingyenes = 0;
            int ismeretlen= 0;
            foreach (var f in fuvarok)
            {
                if (f.FizetésMód == "bankkártya")
                {
                    bankkártya++;
                }
                if (f.FizetésMód == "készpénz")
                {
                    készpénz++;
                }
                if (f.FizetésMód == "vitatott")
                {
                    vitatott++;
                }
                if (f.FizetésMód == "ingyenes")
                {
                    ingyenes++;
                }
                if (f.FizetésMód == "ismeretlen")
                {
                    ismeretlen++;
                }
            }
            //6
            double ÖsszMérföld = 0;
            foreach (var f in fuvarok)
            {
                ÖsszMérföld += f.Távolság;
            }
            Console.WriteLine($"6.feladat: {ÖsszMérföld * 1.6:0.00}km");

            Console.ReadKey();
        }
    }
}
