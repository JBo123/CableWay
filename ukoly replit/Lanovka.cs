using System;
namespace ukoly_replit
{
	public class Lanovka
	{
		public int Delka { get; set; }
		public double Nosnost { get; set; }
		public double Zatizeni { get; private set; }
		public bool VolnoDole { get; set; }
		public bool VolnoNahore { get; set; }
		Clovek[] lan;


        public Lanovka(int Delka, double Nosnost)
		{
			this.Delka = Delka;
			this.Nosnost = Nosnost;
			lan = new Clovek[Delka];

		}


        int sedackaBot = 0;
		int sedackaTop = 0;

        public bool Nastup(Clovek clovek)
		{
            if (((Zatizeni + clovek.Hmotnost) <= Nosnost) && VolnoDole)
            {
				lan[sedackaBot] = clovek;
                Zatizeni += clovek.Hmotnost;
                return true;
            }
            else return false;
        }
		public Clovek Vystup()
		{
			if (sedackaBot < Delka/2) sedackaTop = sedackaBot + Delka / 2;
			if (sedackaBot > Delka/2) sedackaTop = sedackaBot - Delka / 2;
            return lan[sedackaBot + Delka/2];
		}
		public void Jed()
		{
			if (lan[sedackaTop] == null)
			{
				if (sedackaBot != 9) sedackaBot++;
				if (sedackaBot == 9) sedackaBot = 0;
			}
			else throw new IndexOutOfRangeException();
			
	

		}
	}
}

