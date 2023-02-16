using System;


namespace Fibonaci;
public class Fibonaci
{
    public static void Main()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 20; i++)
        {
            if (i < 2) { list.Add(i); }
            else
            {
                int x = list[i - 1] + list[i - 2];
                list.Add(x);
            }
        }
        list.ForEach(Console.WriteLine);
    }
}
