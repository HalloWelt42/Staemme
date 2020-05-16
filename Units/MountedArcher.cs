using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class MountedArcher : MobileUnit
  {
    public MountedArcher()
    {
      this.Wood = 250;
      this.Clay = 100;
      this.Iron = 150;

      this.PopulationSize = 5;

      this.OffensiveStrength = 120;
      this.GeneralDefense = 40;
      this.CavalryDefense = 30;
      this.ArcherDefence = 50;

      this.Speed = 10;
      this.Haul = 50;
    }
  }
}
