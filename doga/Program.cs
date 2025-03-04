namespace doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jatek witcher = new Jatek("The Witcher 3", "RPG", 12000);
            Jatek fifa = new Jatek("FIFA 23", "Sport", 18000);
            Jatek cyberpunk = new Jatek("Cyberpunk 2077", "RPG", 15000);
            Felhasznalo adam = new Felhasznalo("Ádám", 20000);

            JatekBolt jatekBolt = new JatekBolt();

            jatekBolt.JatekHozzaadas(witcher);
            jatekBolt.JatekHozzaadas(fifa);
            jatekBolt.JatekHozzaadas(cyberpunk);
            jatekBolt.FelhasznaloHozzaadas(adam);

            Jatek foundWitcher = jatekBolt.KeresJatek("The Witcher 3");
            if (foundWitcher != null)
            {
                adam.Vasarlas(foundWitcher);
            }

            adam.Feltoltes(10000);

            Jatek foundCyberpunk = jatekBolt.KeresJatek("Cyberpunk 2077");
            if (foundCyberpunk != null)
            {
                adam.Vasarlas(foundCyberpunk);
            }

            adam.KonyvtarMegtekintes();
        }
    }
}