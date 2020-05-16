using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class Paladin : MobileUnit
  {
    public Paladin()
    {
      this.Wood = 20;
      this.Clay = 20;
      this.Iron = 40;

      this.PopulationSize = 10;

      this.OffensiveStrength = 150;
      this.GeneralDefense = 250;
      this.CavalryDefense = 400;
      this.ArcherDefence = 150;

      this.Speed = 10;
      this.Haul = 100;
    }
  }
}
