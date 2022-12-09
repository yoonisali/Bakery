using System.Collections.Generic;
using Bakery.Program;

namespace Bakery.Models
{
  public class Bread 
  {
    private int breadCount;

    public Bread(int count)
    {
      breadCount = count;
    }

    public double GetCost()
    {
      int freeLoaves = breadCount / 3;
      int totalCost = breadCount * 5 - freeLoaves * 5;

      return totalCost;
    }

  }

  public class Pastry
  {

  }
}