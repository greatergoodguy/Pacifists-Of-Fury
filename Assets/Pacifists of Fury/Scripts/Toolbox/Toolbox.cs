

using System;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Collections.Generic;

public static class Toolbox {


	public static void Log(string message) {
#if UNITY_EDITOR || UNITY_EDITOR_64 || UNITY_EDITOR_OSX
		StackFrame frame = new StackFrame(1);
		MethodBase method = frame.GetMethod();
		string tag = method.DeclaringType.ToString();

		UnityEngine.Debug.Log(tag + ": " + message);
#elif UNITY_ANDROID
        UnityEngine.Debug.Log(message);
#else
		UnityEngine.Debug.Log(message);
#endif
	}

	public static Sprite LoadSprite(string spriteName) {
		Sprite sprite = Resources.Load<Sprite>(spriteName);
		return sprite;
	}

	public static GameObject Create(string resourceName) {
		GameObject newGO = Resources.Load<GameObject>(resourceName);
		if (newGO == null) {
			newGO = Resources.Load<GameObject>("Mock");
		}

		newGO = GameObject.Instantiate<GameObject>(newGO);
		newGO.name = resourceName;
		return newGO;
	}

	public static GameObject Create(string resourceName, Vector3 position) {
		GameObject newGO = Create(resourceName);
		newGO.transform.position = position;
		return newGO;
	}

	public static bool NearlyEqual(double a, double b, double epsilon) {
		double absA = Math.Abs(a);
		double absB = Math.Abs(b);
		double diff = Math.Abs(a - b);

		if (a == b) {
			// shortcut, handles infinities
			return true;
		}
		else if (a == 0 || b == 0 || diff < Double.Epsilon) {
			// a or b is zero or both are extremely close to it
			// relative error is less meaningful here
			return diff < epsilon;
		}
		else {
			// use relative error
			return diff / (absA + absB) < epsilon;
		}
	}

	public static bool NearlyEqualZero(double a) {
		return NearlyEqual(a, 0, 0.00001f);
	}

	public static bool IsVectorValid(Vector3 vector) {
		return !float.IsNaN(vector.x) && !float.IsNaN(vector.y) && !float.IsNaN(vector.z);
	}

	private static Regex patternAlphaNumSpecialChar = new Regex("[0-9a-zA-Z._^%$#!~@,-?*'’\"]");
	public static string PadString(string completeString, string currentString) {
		String remainingString = completeString.Substring(currentString.Length);
		String remainingStringScrubbed = patternAlphaNumSpecialChar.Replace(remainingString, "\u00a0");
		return currentString + remainingStringScrubbed;
	}

	public static void DumpToConsole(object obj) {
		var output = JsonConvert.SerializeObject(obj);
		UnityEngine.Debug.Log(output);
	}

	public static T GetRandomItem<T>(List<T> list) {
		if (list.Count == 0) {
			return default(T);
		}

		int index = UnityEngine.Random.Range(0, list.Count);
		return list[index];
	}
}