using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class Ram : MobileUnit
  {
    public Ram()
    {
      this.Wood = 300;
      this.Clay = 200;
      this.Iron = 200;

      this.PopulationSize = 5;

      this.OffensiveStrength = 20;
      this.GeneralDefense = 50;
      this.CavalryDefense = 20;
      this.ArcherDefence = 30;

      this.Speed = 30;
      this.Haul = 0;
    }
  }
}
