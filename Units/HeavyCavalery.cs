using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staemme.Units
{
  class HeavyCavalery : MobileUnit
  {
    public HeavyCavalery()
    {
      this.Wood = 200;
      this.Clay = 150;
      this.Iron = 600;

      this.PopulationSize = 6;

      this.OffensiveStrength = 150;
      this.GeneralDefense = 200;
      this.CavalryDefense = 80;
      this.ArcherDefence = 180;

      this.Speed = 11;
      this.Haul = 50;
    }
  }
}
