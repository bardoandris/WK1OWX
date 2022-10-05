using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK1OWX.Model
{
    public class Work
    {
        private int minutes, materialCost;
        public string Name { get; }
        public int Minutes { get { return minutes % 60; } }
        public int Hours { get { return minutes / 60; } }
        public int MaterialCost { get { return materialCost; } }
        public Work(string Name, int minutes, int materialCost)
        {
            this.minutes = minutes;
            this.materialCost = materialCost;
            this.Name = Name;
        }
        
    }

}
