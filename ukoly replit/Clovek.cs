using System;
namespace ukoly_replit
{
	public class Clovek
	{
		public string Jmeno { get; set; }
		public double Hmotnost { get; set; }

        public Clovek(string jmeno, double hmotnost)
        {
            Jmeno = jmeno;
            Hmotnost = hmotnost;
        }
    }
}

