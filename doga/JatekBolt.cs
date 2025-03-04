using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga
{
    internal class JatekBolt
    {
        public List<Jatek> Jatekok = new List<Jatek>();
        public List<Felhasznalo> Felhasznalok = new List<Felhasznalo>();
        
        public JatekBolt() 
        { 
        }

        public void JatekHozzaadas(Jatek jatek)
        {
            Jatekok.Add(jatek);
        }

        public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
        {
            Felhasznalok.Add(felhasznalo);
        }

        public Jatek KeresJatek(string cim)
        {

            return Jatekok.Find(jatek => jatek.Cim == cim);
        }

        public Felhasznalo KeresFelhasznalo(string nev)
        {

            return Felhasznalok.Find(felhasznalo => felhasznalo.Nev == nev);
        }
    }
}
