using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK1OWX
{
	internal class Work
	{
		private int minutes, materialCost;
		public string Name { get; }
		public int Minutes { get { return minutes % 60; } }
		public int Hours { get { return minutes / 60; } }
		public int MaterialCost { get { return materialCost; } }
		private Work(string Name, int minutes, int materialCost )
		{
			this.minutes = minutes;
			this.materialCost = materialCost;
			this.Name = Name;
		}
		internal static Work ParseWork(string line)
		{ 
			int time, cost;
			string Name;
			var segments = line.Split(';');
			if (segments.Length != 3)
			{
				throw new ArgumentOutOfRangeException("Nem lehet a paramétert három tagra bontani!");
			}
			if (!(int.TryParse(segments[1], out time) && int.TryParse(segments[2], out cost)))
			{
				throw new InvalidDataException("Nem lehetett átalakítani az adatot szám formátumra");
			}
			Name = segments[0];
			return new Work(Name, time, cost);
		}
	}
	
}
