using System.Collections;

namespace Lab_10
{
  public class SortByName: IComparer
  {
    public int Compare(object? x, object? y)
    {
      Watch w1 = x as Watch;
      Watch w2 = y as Watch;
      int comparer = String.Compare(((Watch)x).BrandName, ((Watch)y).BrandName);
      if (comparer < 0)
        return -1;
      else if (comparer == 0)
        return 0;
      else return 1;
    }
  }
}
