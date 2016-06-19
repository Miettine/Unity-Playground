using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System;

public class OpenLink : MonoBehaviour {
	public InputField urlText;

	public void OpenLinkJSPlugin() {
		string givenUrl = urlText.text;

		Debug.Log(Uri.IsWellFormedUriString(givenUrl, UriKind.RelativeOrAbsolute));
		//TODO: add "is string a proper url" -check right here"

#if !UNITY_EDITOR
		openWindow(givenUrl);
		//Source: http://va.lent.in/opening-links-in-a-unity-webgl-project/
#else
		Debug.LogError("Cannot open URL-links in editor.");
	#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}