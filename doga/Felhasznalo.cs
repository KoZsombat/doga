using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace doga
{
    internal class Felhasznalo
    {
        public List<Jatek> Konyvtar = new List<Jatek>();

        public string Nev { get; set; }
        public int Egyenleg { get; set; }

        public Felhasznalo(string nev, int egyenleg)
        {
            this.Nev = nev;
            this.Egyenleg = egyenleg;
            this.Konyvtar.Clear();
        }

        public void Vasarlas(Jatek jatek)
        {
            if (!Konyvtar.Contains(jatek) && jatek.Ar <= Egyenleg)
            {
                Konyvtar.Add(jatek);
                Egyenleg -= jatek.Ar;
                Console.WriteLine($"{jatek.Cim} sikeresen megvásárolva!");
            }
            else
            {
                Console.WriteLine($"Nem sikerült megvásárolni a(z) {jatek.Cim} játékot.");
            }
        }

        public void KonyvtarMegtekintes()
        {
            if (Konyvtar.Count == 0)
            {
                Console.WriteLine("Nincsenek játékok a könyvtárban.");
            }
            else
            {
                Console.WriteLine("Játékok a könyvtárban:");
                foreach (var jatek in Konyvtar)
                {
                    Console.WriteLine(jatek.Cim);
                }
            }
        }

        public void Feltoltes(int osszeg)
        {
            Egyenleg += osszeg;
            Console.WriteLine($"Egyenleg feltöltve: +{osszeg} Ft");
        }
    }
}
