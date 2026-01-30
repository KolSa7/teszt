using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszt
{
	internal class Adat
	{
		private string nev;
		private int ar;
		private double valami;

		public Adat(string nev, int ar, double valami)
		{
			this.nev = nev;
			this.ar = ar;
			this.valami = valami;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Ar { get => ar; set => ar = value; }
		public double Valami { get => valami; set => valami = value; }

		public override string ToString()
		{
			return $"{this.nev} : {this.ar} Ft";
		}
	}
}
