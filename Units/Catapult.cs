using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class Catapult : MobileUnit
  {
    public Catapult()
    {
      this.Wood = 320;
      this.Clay = 400;
      this.Iron = 150;

      this.PopulationSize = 8;

      this.OffensiveStrength = 100;
      this.GeneralDefense = 100;
      this.CavalryDefense = 50;
      this.ArcherDefence = 100;

      this.Speed = 30;
      this.Haul = 0;
    }
  }
}

