using UnityEngine;
using System.Collections;

public class Host : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Welcome to tonight's talk show! "+System.DateTime.Now);
		Debug.Log(LoneWolf.Instance.Speak());
		Debug.Log(EmoKid.Instance.Speak());
		Debug.Log(Renegade.Instance.Speak());
	}
}
