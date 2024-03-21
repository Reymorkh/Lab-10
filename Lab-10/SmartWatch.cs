using static Lab_10.Logic;

namespace Lab_10
{
  public class SmartWatch : DigitalWatch, IInit, IComparable, ICloneable
  {
    private string operatingSystem = "No System";
    private bool heartRateSensor = false;

    public SmartWatch() { }
    public SmartWatch(string name, short year, int id, string display, string os, bool hr) : base(name, year, id, display)

    {
      OperatingSystem = os;
      HeartRateSensor = hr;
    }

    public bool HeartRateSensor 
    {
      get => heartRateSensor;
      private set => heartRateSensor = value;
    }

    public string OperatingSystem
    {
      get => operatingSystem;
      private set 
      {
        if (value != null)
          operatingSystem = value;
        else
          throw new NullReferenceException();
      }
    }

    public override string Show() => "Умные часы " + BrandName + " " + YearOfIssue + " года выпуска. ОС — " + OperatingSystem + " измеритель пульса " + (HeartRateSensor ? "присутствует. " : "отсутствует. " + IdNumb);
    public override string ToString() => "Умные часы " + BrandName + " " + YearOfIssue + " года выпуска. ОС — " + OperatingSystem + " измеритель пульса " + (HeartRateSensor ? "присутствует. " : "отсутствует. " + IdNumb);
    public override void Init()
    {
      base.Init();
      (this.OperatingSystem, this.HeartRateSensor) = (GetString("название ОС"), true);
    }

    public override void RandomInit()
    {
      base.RandomInit();
      Random rng = new();
      this.OperatingSystem = OperatingSystems[rng.Next(OperatingSystems.Length)];
      this.HeartRateSensor = rng.Next(2) == 1;
    }

    public override bool Equals(object? obj)
    {
      //if (obj == null || obj is not SmartWatch watch)
      //  return false;
      return base.Equals(obj) && ((SmartWatch)obj).OperatingSystem == this.OperatingSystem && ((SmartWatch)obj).HeartRateSensor == this.HeartRateSensor;
    }

   // public override object ShallowCopy() => MemberwiseClone();

    public override object Clone()
    {
      SmartWatch watch = new SmartWatch();
      watch.BrandName = BrandName;
      watch.YearOfIssue = YearOfIssue;
      watch.DisplayType = DisplayType;
      watch.OperatingSystem = OperatingSystem;
      watch.HeartRateSensor = HeartRateSensor;
      return watch;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(BrandName, YearOfIssue, DisplayType, HeartRateSensor, OperatingSystem);
    }
  }
}