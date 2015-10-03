using UnityEngine;
using System.Collections;

public static class BitmaskExtensions
{
  // Pass in a bitmask and return a specific bit
  // Useful for getting a single enum value from a flag type enum field
	public static int ReturnRandomBit(int bitmask)
	{
    int? selectedValue = null;
    
    for (int i = 0; ; i++)
    {
    	int checkVal = bitmask & 1;
    	if (checkVal == 1)
    	{
    	  if (selectedValue = null || Random.Range(0, 2) == 0)
    	  {
    	    selectedValue = 1 << i;
    	  }
    	}
    	bitmask = bitmask >> 1;
    
    	if (bitmask == 0) break;
    }
    
    return selectedValue;
	}
}
