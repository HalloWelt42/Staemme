using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class SwordsMan : MobileUnit
  {
    public SwordsMan()
    {
      this.Wood = 30; 
      this.Clay = 30;  
      this.Iron = 70;

      this.PopulationSize = 1;

      this.OffensiveStrength = 25;
      this.GeneralDefense = 50;
      this.CavalryDefense = 15;
      this.ArcherDefence = 40;

      this.Speed = 22;
      this.Haul = 15;
    }
  }
}
