using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    if (arr.Length <= 0) return 0;
    
    List<int> positiveNumbers = new();
    
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
          positiveNumbers.Add(arr[i]);  
        }
    }
    
    return positiveNumbers.Sum();
  }
}
