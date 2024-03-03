using System.Reflection.Emit;
using static Lab_10.Logic;

namespace Lab_10
{
  public abstract class Watch : IInit, IComparable, ICloneable
  {
    private string brandName = "No brand";
    private short yearOfIssue = 1;

    public Watch() { }

    public Watch(string name, short year)
    {
      BrandName = name;
      YearOfIssue = year;
    }

    public string BrandName
    {
      get => brandName;
      internal set => brandName = value;
    }

    public virtual short YearOfIssue
    {
      get => yearOfIssue;
      set
      {
        if (value < 1)
          throw new ArgumentException("Значение меньше допустимого");
        else if (value > 2024)
          throw new ArgumentException("Значение больше допустимого");
        else
          yearOfIssue = value;
      }
    }

    public abstract void Init();
    public abstract void RandomInit();

    //public override bool Equals(object? obj)
    //{
    //  if (obj != null || obj is not Watch)
    //    return false;
    //  return ((Watch)obj).BrandName == this.BrandName && ((Watch)obj).YearOfIssue == this.YearOfIssue;
    //}

    public abstract int CompareTo(object? obj);
    public abstract object Clone();
    public abstract object ShallowCopy();
    public override int GetHashCode()
    {
      return HashCode.Combine(brandName, yearOfIssue, BrandName, YearOfIssue);
    }

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
        if (obj == null || obj is not IdNumber id)
          return false;
        return id.Number == this.Number;
      }

      public override string ToString() => $"{Number}";

    }
  }
}