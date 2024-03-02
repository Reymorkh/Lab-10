namespace Lab_10
{
  internal static class Logic
  {
    public static readonly string[] Brands = new string[] { "Cartier", "Ulysse Nardin", "Zenith", "Jaeger-LeCoultre", "IWC", "Breitling", "Longines", "Oris", "Bomberg", "Edox", "Rado", "Tissot", "Roamer", "Certina", "Jacques du Manoir" };
    public static readonly string[] DisplayTypes = new string[] { "Liquid-crysta", "Light-emitting diode", "backlit LCD", "OLED", "AMOLED" };
    public static readonly string[] Styles = new string[] { "Luxury", "Sport", "military", "Diver", "Fitness", "Pocket"};
    public static readonly string[] OperatingSystems = new string[] { "Apple WatchOS", "Wear", "Fitbit" , "Garmin" };

    public static string GetString(string obj)
    {
      Console.Write("Введите " + obj + ": ");
      return Console.ReadLine();
    }

    public static short GetShort(string obj)
    {
      Console.Write("Введите " + obj + ": ");
      return Convert.ToInt16(Console.ReadLine());
    }

    public static double GetDouble(string obj)
    {
      Console.Write("Введите " + obj + ": ");
      return Convert.ToDouble(Console.ReadLine());
    }
  }
}
