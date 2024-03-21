using static Lab_10.Logic;
namespace Lab_10
{
  public class AnalogWatch : Watch, IInit, IComparable, ICloneable
  {
    private string style = "No style";

    public string Style
    {
      get => style;
      private set
      {
        if (value != null)
          style = value;
        else
          throw new NullReferenceException();
      }
    }

    public AnalogWatch() { }
    public AnalogWatch(string name, short year, int id, string sty) : base(name, year, id) => Style = sty;

    public override string Show() => ("Аналоговые часы " + BrandName + " " + YearOfIssue + " года выпуска и типа " + Style + ". " + IdNumb);
    public override string ToString() => ("Аналоговые часы " + BrandName + " " + YearOfIssue + " года выпуска и типа " + Style + ". " + IdNumb);
    public override void Init() 
    {
      base.Init();
      this.Style = GetString("стиль"); 
    }

    public override void RandomInit()
    {
      base.RandomInit();
      this.Style = Styles[new Random().Next(Styles.Length)];
    }

    public override bool Equals(object? obj)
    {
      //if (obj == null || obj is not AnalogWatch watch)
      //  return false;
      return base.Equals(obj) && ((AnalogWatch)obj).Style == this.Style;
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

    public override object Clone()
    {
      AnalogWatch watch = new AnalogWatch();
      watch.BrandName = BrandName;
      watch.YearOfIssue = YearOfIssue;
      watch.Style = Style;
      return watch;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(base.GetHashCode(), BrandName, YearOfIssue, Style);
    }

    //public override object ShallowCopy() => MemberwiseClone();
  }
}