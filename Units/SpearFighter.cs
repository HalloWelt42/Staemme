using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class SpeerFigther : MobileUnit
  {
    public SpeerFigther()
    {
      this.Wood = 50; 
      this.Clay = 30;  
      this.Iron = 10;

      this.PopulationSize = 1;

      this.OffensiveStrength = 10;
      this.GeneralDefense = 15;
      this.CavalryDefense = 45;
      this.ArcherDefence = 20;

      this.Speed = 18;
      this.Haul = 25;
    }
  }
}
