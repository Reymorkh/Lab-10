using Lab_10;

namespace Consolechka
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Watch[] watches = new Watch[20];
      Random rnd = new Random();
      for (int i = 0; i < watches.Length; i++)
      {
        int menu = rnd.Next(3);
        switch (menu)
        {
          case 0:
            watches[i] = new SmartWatch();
            break;
          case 1:
            watches[i] = new AnalogWatch();
            break;
            case 2:
            watches[i] = new DigitalWatch();
            break;
        }
        watches[i].RandomInit();
        Console.WriteLine(watches[i].Show());
      }
    }
  }
}