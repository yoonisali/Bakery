using Bakery.Program;

namespace Bakery.Models
{
  public class Pastry
  {
    private int pastryCount;

    public Pastry(int count)
    {
      pastryCount = count;
    }

    public double GetCost()
    {
      if (pastryCount <= 3)
      {
        return pastryCount * 2;
      } 
      else if (pastryCount <= 5)
      {
        return 7;
      }
      else if (pastryCount <= 6)
      {
        return 9;
      }
      else 
      {
        return 10;
      }
    }

  }
}