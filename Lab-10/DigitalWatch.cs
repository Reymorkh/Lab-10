using static Lab_10.Logic;

namespace Lab_10
{
  public class DigitalWatch : Watch, IInit, IComparable, ICloneable
  {
    private string displayType = "No display";

    public string DisplayType
    {
      get => displayType;
      internal set => displayType = value;
    }

    public DigitalWatch() { }
    public DigitalWatch(string name, short year, string display) : base(name, year) => DisplayType = display;

    public override string ToString() => ("Электронные часы " + BrandName + " " + YearOfIssue + " года выпуска с типом дисплея: " + DisplayType + ".");
    public override void Init() => (this.BrandName, this.YearOfIssue, this.DisplayType) = (GetString("имя бренда"), GetShort("год выпуска"), GetString("стиль"));
    public override void RandomInit()
    {
      Random rng = new();
      this.BrandName = Brands[rng.Next(Brands.Length)];
      this.YearOfIssue = (short)rng.Next(1970, 2024);
      this.DisplayType = DisplayTypes[rng.Next(DisplayTypes.Length)];
    }


    public override bool Equals(object? obj)
    {
      if (obj != null || obj is not DigitalWatch)
        return false;
      return ((DigitalWatch)obj).BrandName == this.BrandName && ((DigitalWatch)obj).YearOfIssue == this.YearOfIssue && ((DigitalWatch)obj).DisplayType == this.DisplayType;
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