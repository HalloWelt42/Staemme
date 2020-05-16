using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class Scout : MobileUnit
  {
    public Scout()
    {
      this.Wood = 50;
      this.Clay = 50;
      this.Iron = 20;

      this.PopulationSize = 2;

      this.OffensiveStrength = 0;
      this.GeneralDefense = 2;
      this.CavalryDefense = 1;
      this.ArcherDefence = 2;

      this.Speed = 9;
      this.Haul = 0;
    }
  }
}
