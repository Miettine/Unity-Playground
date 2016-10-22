using UnityEngine;
using System.Collections;

public class LoneWolf : Singleton<LoneWolf>, ICanSpeak {

	public string Speak() {
		return "Howwwwwwl!";
	}

}
