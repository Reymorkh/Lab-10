﻿using System.Reflection.Emit;
using static Lab_10.Logic;

namespace Lab_10
{
  public class Watch : IInit, IComparable, ICloneable
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
      internal set
      {
        if (value != null)
          brandName = value;
        else
          throw new NullReferenceException(); 
      }
    }

    public short YearOfIssue
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

    public virtual string Show() => ("Часы " + BrandName + " " + YearOfIssue + " года выпуска.");
    public override string ToString() => ("Аналоговые часы " + BrandName + " " + YearOfIssue + " года выпуска.");
    public virtual void Init() 
    {
      BrandName = GetString("имя бренда");
      YearOfIssue = GetShort("дата выпуска");
    }

    public virtual void RandomInit()
    {
      Random rng = new();
      this.BrandName = Brands[rng.Next(Brands.Length)];
      this.YearOfIssue = (short)rng.Next(1982, 2024);
    }

    public override bool Equals(object? obj)
    {
      if (obj != null || obj is not Watch watch)
        return false;
      return watch.BrandName == this.BrandName && watch.YearOfIssue == this.YearOfIssue;
    }

    public int CompareTo(object? obj)
    {
      if (obj != null)
      {
        if (obj is Watch watch)
          return YearOfIssue.CompareTo(watch.YearOfIssue);
        if (obj is Rectangle)
          return 1;
        return -1;
      }
      throw new ArgumentNullException();
    }

    public virtual object Clone() => new Watch(BrandName, yearOfIssue);

    public object ShallowCopy() => MemberwiseClone();

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