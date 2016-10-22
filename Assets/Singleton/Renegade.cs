using UnityEngine;
using System.Collections;

public class Renegade : Singleton<Renegade>, ICanSpeak {

	public string Speak() {
		StartCoroutine(LateComment("Long live the revolution!"));
		return "Fight the system!";
		
	}

	IEnumerator LateComment(string _comment) {
		yield return new WaitForSeconds(4f);
		Debug.Log(_comment);
	}

}