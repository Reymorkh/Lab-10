using static Consolechka.Logic;
using Lab_10;
using System.Data;
using Лабораторная_работа__9_формы;

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
        Console.WriteLine(watches[i].ToString());
      }


      Console.WriteLine("\n\n");
      Console.WriteLine("Самые новые часы из выборки: " + TheNewestWatch(watches));
      Console.WriteLine("Количество \"смарт\" часов с измерителем пульса: " + SmartWatchHRCounter(watches));
      Console.WriteLine("Уникальные стили аналоговых часов: " + UniqueWatchStyles(watches) + " ");

      Console.WriteLine("\n\n");

      IInit[] Iinits = new IInit[20];
      for (int i = 0; i < Iinits.Length; i++)
      {
        int menu = rnd.Next(4);
        switch (menu)
        {
          case 0:
            Iinits[i] = new SmartWatch();
            break;
          case 1:
            Iinits[i] = new AnalogWatch();
            break;
          case 2:
            Iinits[i] = new DigitalWatch();
            break;
          case 3:
            Iinits[i] = new Rectangle();
            break;
        }
        Iinits[i].RandomInit();
        Console.WriteLine(Iinits[i].ToString());
      }

    }
  }
}