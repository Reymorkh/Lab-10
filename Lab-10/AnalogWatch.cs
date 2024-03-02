using static Lab_10.Logic;
namespace Lab_10
{
  public class AnalogWatch : Watch, IInit, IComparable, ICloneable
  {
    private string style = "No style";

    public string Style
    {
      get => style;
      private set => style = value;
    }

    public AnalogWatch() { }
    public AnalogWatch(string name, short year, string sty) : base(name, year) => Style = sty; 

    public override string ToString() => ("Аналоговые часы " + BrandName + " " + YearOfIssue + " года выпуска и типа " + Style + ".");
    public override void Init() => (this.BrandName, this.YearOfIssue, this.Style) = (GetString("имя бренда"), GetShort("год выпуска"), GetString("стиль"));
    public override void RandomInit()
    {
      Random rng = new();
      this.BrandName = Brands[rng.Next(Brands.Length)];
      this.YearOfIssue = (short)rng.Next(1368, 2024);
      this.Style = Styles[rng.Next(Styles.Length)];
    }

    public override bool Equals(object? obj)
    {
      if (obj != null || obj is not AnalogWatch)
        return false;
      return ((AnalogWatch)obj).BrandName == this.BrandName && ((AnalogWatch)obj).YearOfIssue == this.YearOfIssue && ((AnalogWatch)obj).Style == this.Style;
    }

    public override int CompareTo(object? obj)
    {
      throw new NotImplementedException();
    }

    public override object Clone()
    {
      throw new NotImplementedException();
    }
  }
}