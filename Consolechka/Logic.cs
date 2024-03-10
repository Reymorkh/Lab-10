using Lab_10;

namespace Consolechka
{
  internal static class Logic
  {
    public static string TheNewestWatch(Watch[] arr)
    {
      Watch newest = arr[0];
      foreach (Watch watch in arr)
      {
        if (watch.YearOfIssue > newest.YearOfIssue)
          newest = watch;
      }
      return newest.ToString();
    }

    public static int SmartWatchHRCounter(Watch[] arr)
    {
      int counter = 0;
      foreach (Watch watch in arr)
      {
        if (watch is SmartWatch smart && smart.HeartRateSensor)
          counter++;
      }
      return counter;
    }

    public static string UniqueWatchStyles(Watch[] arr)
    {
      string[] styles = new string[0];
      int[] styleCounter = new int[0];
      foreach(Watch watch in arr)
      {
        if (watch is AnalogWatch analog)
        {
          int numberOfStyle = Array.IndexOf(styles, analog.Style);
          if (numberOfStyle != -1)
          {
            styleCounter[numberOfStyle]++;
          }
          else
          {
            int length = styles.Length;
            Array.Resize(ref styles, length + 1);
            Array.Resize(ref styleCounter, length + 1);
            styles[length] = analog.Style;
          }
        }
      }
      string output = "";
      for (int i = 0; i < styles.Length; i++)
        if (styleCounter[i] == 0)
          output += styles[i];
      return output;
    }

    public static int BinarySearch(Watch[] arr, int searchedNumber)
    {
      int indexLeft = 0, indexRight = arr.Length - 1;
      while (indexLeft <= indexRight)
      {
        int index = (indexLeft + indexRight) / 2;
        if (searchedNumber == arr[index].YearOfIssue)
        {
          return index;
        }
        else if (searchedNumber < arr[index].YearOfIssue)
        {
          indexRight = index - 1;
        }
        else
        {
          indexLeft = index + 1;
        }
      }
      return -1;
    }
  }
}
