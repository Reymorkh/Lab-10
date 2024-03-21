using static Consolechka.Logic;
using Lab_10;
using System.Threading;

namespace Consolechka
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      Console.Clear();

      #region массив типа Watch и его показ
      Watch[] watches = new Watch[20];                                 //массив типа Watch и его показ
      Random rnd = new Random();
      for (int i = 0; i < watches.Length; i++)
      {
        int menu = rnd.Next(4);
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
          case 3:
            watches[i] = new Watch();
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
      #endregion


      #region массив типа IInit и счётчик объектов разных типов в нём
      int smartCount = 0, analogCount = 0, digitalCount = 0, rectangleCount = 0;
      IInit[] Iinits = new IInit[20];                                   //массив типа IInit и счётчик объектов разных типов в нём
      for (int i = 0; i < Iinits.Length; i++)
      {
        int menu = rnd.Next(5);
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
          case 4:
            Iinits[i] = new Watch();
            break;
        }
        Iinits[i].RandomInit();
        Console.WriteLine(Iinits[i].ToString());
      }
      Console.WriteLine("\nУмных: " + smartCount + " Аналоговых: " + analogCount + " Электронных: " + digitalCount + " Прямоугольников: " + rectangleCount);
      Console.WriteLine("\n\n");
      #endregion


      #region Сортировка массива типа Watch с последующим бинарным поиском имени в нём
      Array.Sort(watches, new SortByName());                                              //Сортировка массива типа Watch по имени с последующим бинарным поиском в нём
      if (false)
        foreach (var item in watches)
          Console.WriteLine(item.ToString());
      else
        Console.WriteLine("Массив отсортирован по именам.");
      int result = Array.BinarySearch(watches, new Watch("Cartier", 1, 1), new SortByName());
      Console.WriteLine("Результат бинарного поиска Cartier: " + (result < 0 ? " не найден" : result + 1) + "\n\n") ;
      #endregion



      #region Сортировка массива типа Watch с последующим бинарным поиском числа в нём
      Array.Sort(watches);                                              //Сортировка массива типа Watch с последующим бинарным поиском в нём
      if (false)
        foreach (var item in watches)
          Console.WriteLine(item.ToString());
      else
        Console.WriteLine("Массив отсортирован по годам");
      result = Array.BinarySearch(watches, new Watch("No name", 2002, 1));
      Console.WriteLine("Результат бинарного поиска числа 2002: " + (result < 0 ? " не найден" : result + 1));
      #endregion


      #region попытка продемонстрировать копирование
      Watch watch = new Watch("No brand", 1, 31);                              //попытка продемонстрировать копирование
      Watch watchCopy1 = (Watch)watch.ShallowCopy();
      Watch watchCopy2 = (Watch)watch.Clone();
      Console.WriteLine($"\n\nОригинал: {watch}\nКопия поверхностная: {watchCopy1}\nКопия два: {watchCopy2}");
      watch.IdNumb.Id = 99;
      Console.WriteLine($"Id в оригинале сменилось на 99.\nОригинал: {watch}\nКопия поверхностная: {watchCopy1}\nКопия два: {watchCopy2}");
      #endregion

    }
  }
}