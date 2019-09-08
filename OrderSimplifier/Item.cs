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
        return $"{Name} @{r0(Price)} x {Volume}";
      }
      else
      {
        return $"{Name} {Strike} @{r0(Price)} x {Volume}";
      } 
    }

    private string r0(double v)
    {
      string s = v.ToString("0.000000");
      return s;
    }
  }
}
