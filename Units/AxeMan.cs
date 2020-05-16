using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class AxeMan: MobileUnit
  {
    public AxeMan()
    {
      this.Wood = 60;
      this.Clay = 30;
      this.Iron = 40;

      this.PopulationSize = 1;

      this.OffensiveStrength = 40;
      this.GeneralDefense = 10;
      this.CavalryDefense = 5;
      this.ArcherDefence = 10;

      this.Speed = 18;
      this.Haul = 10;
    }
  }
}
