using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class Archer: MobileUnit
  {
    public Archer()
    {
      this.Wood = 100;
      this.Clay = 30;
      this.Iron = 60;

      this.PopulationSize = 1;

      this.OffensiveStrength = 15;
      this.GeneralDefense = 50;
      this.CavalryDefense = 40;
      this.ArcherDefence = 5;

      this.Speed = 18;
      this.Haul = 10;
    }
  }
}
