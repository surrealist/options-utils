using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSimplifier
{
  class Item
  {
    public string Name { get; set; }
    public int Strike { get; set; } // for LF and SF, Strike is 0.
    public double Price { get; set; }
    public int Volume { get; set; }

    public override string ToString()
    {
      if (Name == "LF" || Name == "SF")
      {
        return $"{Name} @{Price:0.0} x {Volume}";
      }
      else
      {
        return $"{Name} {Strike} @{Price:0.0} x {Volume}";
      } 
    }
  }
}
