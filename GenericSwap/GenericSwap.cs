using System;
using System.Collections.Generic;
using System.Text;

class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    public static void SwapInArray<T>(T[] array, int index1, int index2)
    {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static T FindMin<T>(T[] array) where T : IComparable
    {
        T min = array[0];
        foreach (T t in array)
        {
            if (t.CompareTo(t) < 0)
            {
                min = t;
            }
        }
        return min;
    }
    public static T FindMax<T>(T[] array) where T : IComparable
    {
        T max = array[0];
        foreach (T t in array)
        {
            if (t.CompareTo(t) > 0)
            {
                max = t;
            }
        }
        return max;
    }
    public static void Reverse<T>(T[] array)
    {
        Array.Reverse(array);
    }
}