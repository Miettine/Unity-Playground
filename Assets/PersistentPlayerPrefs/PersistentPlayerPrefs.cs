using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersistentPlayerPrefs : MonoBehaviour {

	public InputField inputField;

	void Start() {
		Debug.Log(Application.persistentDataPath);
	}

	public void Save_OnClick() {
		PlayerPrefs.SetString("big-data", inputField.text);
	}

	public void Load_OnClick() {
		inputField.text = PlayerPrefs.GetString("big-data", "Nothing saved to playerprefs!");
	}

	public void Delete_OnClick() {
		PlayerPrefs.DeleteKey("big-data");
	}
}
