using UnityEngine;
using System.Collections;

public class EmoKid : Singleton<EmoKid>, ICanSpeak {

	public string Speak() {
		return "I'm so lonely...";
	}

}