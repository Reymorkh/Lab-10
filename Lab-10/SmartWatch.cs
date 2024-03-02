using static Lab_10.Logic;

namespace Lab_10
{
  public class SmartWatch : DigitalWatch, IInit, IComparable, ICloneable
  {
    private string operatiningSystem = "No System";
    private bool heartRateSensor = false;

    public SmartWatch() { }
    public SmartWatch(string name, short year, string display, string os, bool hr) : base(name, year, display)
    {
      operatiningSystem = os;
      heartRateSensor = hr;
    }

    public bool HeartRateSensor 
    {
      get => heartRateSensor; 
      private set => heartRateSensor = value;
    }

    public string OperatingSystem
    {
      get => operatiningSystem;
      private set => operatiningSystem = value;
    }

    public override string ToString() => "Умные часы " + BrandName + " " + YearOfIssue + " года выпуска. ОС — " + OperatingSystem + " измеритель пульса " + (HeartRateSensor ? "присутствует." : "отсутствует.");
    public override void Init() => (this.BrandName, this.YearOfIssue, this.DisplayType, this.OperatingSystem, this.HeartRateSensor) = (GetString("имя бренда"), GetShort("год выпуска"), GetString("тип дисплея"), GetString("название ОС"), true);
    public override void RandomInit()
    {
      Random rng = new();
      this.BrandName = Brands[rng.Next(Brands.Length)];
      this.YearOfIssue = (short)rng.Next(1982, 2024);
      this.DisplayType = DisplayTypes[rng.Next(DisplayTypes.Length)];
      this.OperatingSystem = OperatingSystems[rng.Next(OperatingSystems.Length)];
      this.HeartRateSensor = rng.Next(2) == 1;
    }

    public override bool Equals(object? obj)
    {
      if (obj != null || obj is not SmartWatch)
        return false;
      return ((SmartWatch)obj).BrandName == this.BrandName && ((SmartWatch)obj).YearOfIssue == this.YearOfIssue && ((SmartWatch)obj).DisplayType == this.DisplayType && ((SmartWatch)obj).OperatingSystem == this.OperatingSystem && ((SmartWatch)obj).HeartRateSensor == this.HeartRateSensor;
    }
  }
}