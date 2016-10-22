using UnityEngine;
using System.Collections;

public class Renegade : Singleton<Renegade>, ICanSpeak {

	public string Speak() {
		return "Fight the system!";
	}

}