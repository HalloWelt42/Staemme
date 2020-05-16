using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class LightCavalery : MobileUnit
  {
    public LightCavalery()
    {
      this.Wood = 125;
      this.Clay = 100;
      this.Iron = 250;

      this.PopulationSize = 4;

      this.OffensiveStrength = 130;
      this.GeneralDefense = 30;
      this.CavalryDefense = 40;
      this.ArcherDefence = 30;

      this.Speed = 10;
      this.Haul = 80;
    }
  }
}
