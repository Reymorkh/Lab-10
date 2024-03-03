using static Consolechka.Logic;
using Lab_10;

namespace Consolechka
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      Console.Clear();


      Watch[] watches = new Watch[20];                                 //массив типа Watch и его показ
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


      int smartCount = 0, analogCount = 0, digitalCount = 0, rectangleCount = 0;
      IInit[] Iinits = new IInit[20];                                   //массив типа IInit и счётчик объектов разных типов в нём
      for (int i = 0; i < Iinits.Length; i++)
      {
        int menu = rnd.Next(4);
        switch (menu)
        {
          case 0:
            Iinits[i] = new SmartWatch();
            smartCount++;
            break;
          case 1:
            Iinits[i] = new AnalogWatch();
            analogCount++;
            break;
          case 2:
            Iinits[i] = new DigitalWatch();
            digitalCount++;
            break;
          case 3:
            Iinits[i] = new Rectangle();
            rectangleCount++;
            break;
        }
        Iinits[i].RandomInit();
        Console.WriteLine(Iinits[i].ToString());
      }
      Console.WriteLine("\nУмных: " + smartCount + " Аналоговых: " + analogCount + " Электронных: " + digitalCount + " Прямоугольников: " + rectangleCount);


      Console.WriteLine("\n\n");
      Array.Sort(watches);                                              //Сортировка массива типа Watch с последующим бинарным поиском в нём
      foreach(var item in watches)
        Console.WriteLine(item.ToString());
      Console.WriteLine("Результат бинарного поиска по числу 2002: " + BinarySearch(watches, 2002));


      SmartWatch watch = new SmartWatch(); //попытка продемонстрировать копирование
      watch.RandomInit();
      SmartWatch watchCopy1 = (SmartWatch)watch.ShallowCopy();
      watchCopy1.RandomInit();
      SmartWatch watchCopy2 = (SmartWatch)watch.Clone();
      Console.WriteLine($"\n\nОригинал: {watch}\nКопия один: {watchCopy1}\nКопия два: {watchCopy2}");


    }
  }
}