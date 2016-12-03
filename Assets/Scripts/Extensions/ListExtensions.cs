using UnityEngine;
using System.Collections.Generic;

public static class ListExtensions
{
	public static T RandomEntry<T>(this List<T> list)
	{
		return list[Random.Range(0, list.Count)];
	}
	
	public static int RandomIndex<T>(this List<T> list, int excludedIndex = -1)
	{
		if (excludedIndex == -1)
		{
			return Random.Range(0, list.Count);
		}
		return (excludedIndex + Random.Range(1, list.Count)) % list.Count;
	}
	
	public static List<T> ExtractComponent<T>(this List<GameObject> GameObjects)
	{
		List<T> returnList = new List<T>();
		foreach (GameObject go in GameObjects)
		{
			T tempC = go.GetComponent<T>();
			if (tempC != null)
			{
				returnList.Add(tempC);
			}
		}
		return returnList;
	}
}
