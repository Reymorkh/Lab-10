namespace Lab_10
{
  internal static class Logic
  {
    public static readonly string[] Brands = new string[] { "Cartier", "Ulysse Nardin", "Zenith", "Jaeger-LeCoultre", "IWC", "Breitling", "Longines", "Oris", "Bomberg", "Edox", "Rado", "Tissot", "Roamer", "Certina", "Jacques du Manoir" };
    public static readonly string[] DisplayTypes = new string[] { "Liquid-crystal", "Light-emitting diode", "backlit LCD", "OLED", "AMOLED" };
    public static readonly string[] Styles = new string[] { "Luxury", "Sport", "military", "Diver", "Fitness", "Pocket"};
    public static readonly string[] OperatingSystems = new string[] { "Apple WatchOS", "Wear", "Fitbit" , "Garmin" };

    public static string GetString(string aim)
    {
      Console.Write("Введите " + aim + ": ");
      string input ="";
      while (input == "" || input == null)
        input = Console.ReadLine();
      return input;
    }

    public static short GetShort(string aim)
    {
      Console.Write("Введите " + aim + ": ");
      short input;
      while (short.TryParse(Console.ReadLine(), out input))
        Console.WriteLine("Неправильный ввод");
      return input;
    }

    public static double GetDouble(string aim)
    {
      Console.Write("Введите " + aim + ": ");
      double input;
      while (double.TryParse(Console.ReadLine(), out input))
        Console.WriteLine("Неправильный ввод");
      return input;
    }

    public static int GetInt(string aim)
    {
      Console.Write("Введите " + aim + ": ");
      int input;
      while (int.TryParse(Console.ReadLine(), out input))
        Console.WriteLine("Неправильный ввод");
      return input;
    }
  }
}
