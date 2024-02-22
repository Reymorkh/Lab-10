using System.Reflection.Emit;
using static Lab_10.Logic;

namespace Lab_10
{
  public abstract class Watch : IInit
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

    public abstract string Show();
    public abstract void Init();
    public abstract void RandomInit();

    public override bool Equals(object? obj)
    {
      if (obj != null || obj is not Watch)
        return false;
      return ((Watch)obj).BrandName == this.BrandName && ((Watch)obj).YearOfIssue == this.YearOfIssue;
    }
  }
}