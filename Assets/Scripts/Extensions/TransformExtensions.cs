using UnityEngine;
using System.Collections;

public enum Axis { X, Y, Z, XY, XZ, YZ, ALL }

public static class TransformExtensions
{
  // Use as coroutine only!
	public static IEnumerator LinearShake(this Transform transform, float duration, float magnitude, Axis axis, bool usePause = true)
	{
		for (float time = 0; time < duration; time += usePause ? Time.deltaTime : Time.unscaledDeltaTime)
		{
			if (!usePause || Time.timeScale != 0)
			{
				Vector3 offset = new Vector3(
					axis == Axis.X || axis == Axis.XY || axis == Axis.XZ || axis == Axis.ALL ? Random.Range(-magnitude, magnitude) : 0,
					axis == Axis.Y || axis == Axis.XY || axis == Axis.YZ || axis == Axis.ALL ? Random.Range(-magnitude, magnitude) : 0,
					axis == Axis.Z || axis == Axis.XZ || axis == Axis.YZ || axis == Axis.ALL ? Random.Range(-magnitude, magnitude) : 0);

				transform.position += offset;
				yield return new WaitForEndOfFrame();
				transform.position -= offset;
			}
		}
	}
}
