namespace Lab_10
{
  internal static class Logic
  {
    public static readonly string[] Brands = new string[] { "Cartier", "Ulysse Nardin", "Zenith", "Jaeger-LeCoultre", "IWC", "Breitling", "Longines", "Oris", "Bomberg", "Edox", "Rado", "Tissot", "Roamer", "Certina", "Jacques du Manoir" };
    public static readonly string[] DisplayTypes = new string[] { "Liquid-crystal", "Light-emitting diode", "backlit LCD", "OLED", "AMOLED" };
    public static readonly string[] Styles = new string[] { "Luxury", "Sport", "military", "Diver", "Fitness", "Pocket"};
    public static readonly string[] OperatingSystems = new string[] { "Apple WatchOS", "Wear", "Fitbit" , "Garmin" };

    public static string GetString(string obj)
    {
      Console.Write("Введите " + obj + ": ");
      string input ="";
      while (input == "" || input == null)
        input = Console.ReadLine();
      return input;
    }

    public static short GetShort(string obj)
    {
      Console.Write("Введите " + obj + ": ");
      short input;
      while (short.TryParse(Console.ReadLine(), out input))
        Console.WriteLine("Неправильный ввод");
      return input;
    }

    public static double GetDouble(string obj)
    {
      Console.Write("Введите " + obj + ": ");
      double input;
      while (double.TryParse(Console.ReadLine(), out input))
        Console.WriteLine("Неправильный ввод");
      return input;
    }
  }
}
