# UnityUtilities
A collection of C# scripts to assist with frequent Unity use cases

Verified working on Unity 2019.2.10f1.

## List Extensions
[ListExtensions.cs](Assets/Scripts/Extensions/ListExtensions.cs)

A collection of useful functions that can be called directly on lists.

### RandomEntry
```C#
List<int> myList = [1, 2, 3, 4];
Debug.Log(myList.RandomEntry());
// Will return either 1, 2, 3, or 4
```

### RandomIndex
```C#
List<int> myList = [1, 2, 3, 4];
Debug.Log(myList.RandomIndex());
// Will return either 0, 1, 2, or 3

Debug.Log(myList.RandomIndex(1));
// Will return either 0, 2, or 3
```

### ExtractComponent
```C#
List<GameObject> candyObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Candy"));
// Build a list of game objects to extract components from
List<CandyComponent> candies = candyObjects.ExtractComponent<CandyComponent>();
// Returns a list of CandyComponents attached to gameobjects in candyObjects
List<Transform> candyTransforms = candyObjects.ExtractComponent<Transform>();
// Returns a list of Transforms attached to gameobjects in candyObjects
```

## Transform Extensions
[TransformExtensions.cs](Assets/Scripts/Extensions/TransformExtensions.cs)

### LinearShake
```C#
StartCoroutine(Camera.main.transform.LinearShake(2f, 2f, Axis.XY));
// Will cause the camera to shake for 2 seconds on the x and y axis individually
// Will stop the camera shake if the game's Time.timeScale is set to 0

StartCoroutine(transform.LinearShake(4f, 8f, Axis.ALL, false));
// Will cause this game object to shake for 4 seconds on all three axis
// Will continue to run even if the game's Time.timeScale is set to 0
```

## Bitmask Extensions
[BitmaskExtensions.cs](Assets/Scripts/Extensions/BitmaskExtensions.cs)

### ReturnRandomBit
```C#
Debug.Log(5.ReturnRandomBit());
// Will return either 1 or 4
```
