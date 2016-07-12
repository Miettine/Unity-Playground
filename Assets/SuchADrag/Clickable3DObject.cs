using UnityEngine;
using System.Collections;

public class Clickable3DObject : MonoBehaviour {

	void OnMouseDown() {
		Debug.Log (gameObject.name + ": OnMouseDown");
	}

	void OnMouseUp() {
		Debug.Log(gameObject.name + ": OnMouseUp");
	}

	void OnMouseDrag() {
		Debug.Log(gameObject.name + ": Drag");
	}
}
