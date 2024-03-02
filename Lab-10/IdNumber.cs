using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
  public class IdNumber
  {
    public int number;

    public int Number
    {
      get => number;
      set
      {
        if (value < 0)
          throw new ArgumentException("Меньше нуля, а-йа-йай.");
        else
          number = value;
      }
    }
    public IdNumber(int numb) => Number = numb;

    public override bool Equals(object? obj)
    {
      if (obj  == null && obj is not IdNumber)
        return false;
      if (obj == this) return true;
    }

    public override string ToString() => $"{Number}";

  }
}
