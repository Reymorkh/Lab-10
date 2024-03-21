using static Lab_10.Logic;

namespace Lab_10
{
  public class DigitalWatch : Watch, IInit, IComparable, ICloneable
  {
    private string displayType = "No display";

    public string DisplayType
    {
      get => displayType;
      internal set
      { 
        if (value != null)
          displayType = value;
        else
          throw new NullReferenceException();
      }
    }

    public DigitalWatch() { }
    public DigitalWatch(string name, short year, int id, string display) : base(name, year, id) => DisplayType = display;

    public override string Show() => ("Электронные часы " + BrandName + " " + YearOfIssue + " года выпуска с типом дисплея: " + DisplayType + ". " + IdNumb);
    public override string ToString() => ("Электронные часы " + BrandName + " " + YearOfIssue + " года выпуска с типом дисплея: " + DisplayType + ". " + IdNumb);
    public override void Init()
    {
      base.Init();
      this.DisplayType = GetString("стиль");
    }

    public override void RandomInit()
    {
      base.RandomInit();
      this.DisplayType = DisplayTypes[new Random().Next(DisplayTypes.Length)];
    }


    public override bool Equals(object? obj)
    {
      //if (obj == null || obj is not DigitalWatch watch)
      //  return false;
      return base.Equals(obj) && ((DigitalWatch)obj).DisplayType == this.DisplayType;
    }

    //public override int CompareTo(object? obj)
    //{
    //  if (obj != null)
    //  {
    //    if (obj is Watch watch)
    //      return YearOfIssue.CompareTo(watch.YearOfIssue);
    //    if (obj is Rectangle)
    //      return 1;
    //    return -1;
    //  }
    //  throw new ArgumentNullException();
    //}

  //  public override object ShallowCopy() => MemberwiseClone();

    public override object Clone()
    {
      DigitalWatch watch = new DigitalWatch();
      watch.BrandName = BrandName;
      watch.YearOfIssue = YearOfIssue;
      watch.DisplayType = DisplayType;
      return watch;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(BrandName, YearOfIssue, displayType, DisplayType);
    }
  }
}