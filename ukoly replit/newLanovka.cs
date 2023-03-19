using System;
namespace ukoly_replit
{
	public class newLanovka
	{
        public int Delka { get; set; }
        public double Nosnost { get; set; }
        public double Zatizeni { get; private set; }
        Clovek[] lan;
        private int vstup;
        private int vystup;

        public newLanovka(int Delka, double Nosnost)
        {
            this.Delka = Delka;
            this.Nosnost = Nosnost;
            lan = new Clovek[Delka];

            vstup = 0;
            vystup = Delka / 2;
        }

        public bool Nastup(Clovek clovek)
        {
            if (lan[vstup] == null && Zatizeni + clovek.Hmotnost <= Nosnost)
            {
                Console.WriteLine("nastup");
                lan[vstup] = clovek;
                Zatizeni += clovek.Hmotnost;
                return true;
            }
            else return false;
        }
        public Clovek Vystup()
        {
            Clovek escaper;
            if (lan[vystup] != null)
            {
                Console.WriteLine("vystup");
                escaper = lan[vystup];
                lan[vystup] = null;
                Zatizeni -= escaper.Hmotnost;

                return escaper;
            }
            else return null;
        }
        public void Jed()
        {
            if (lan[vystup]!= null) throw new Exception("je to spatne");
            Clovek temp = lan[lan.Length - 1];
            for (int i = lan.Length-1; i >= 0; i--)
            {
                if (i == 0)
                    lan[0] = temp;
                else
                    lan[i] = lan[i - 1];
            }
            Console.WriteLine("jed") ;
        }
    }
}

