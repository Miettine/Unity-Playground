using UnityEngine;
using System.Collections;

public class HighLevelClass : MonoBehaviour {

	void OnListValueChanged(int _value) {
		Debug.Log("HighLevelClass, OnListValueChanged:" + _value);
	}
}
