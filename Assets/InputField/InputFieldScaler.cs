using UnityEngine;
using System.Collections;

public class InputFieldScaler : MonoBehaviour {

	RectTransform rectTransform;
	public RectTransform textRectTransform;
	// Use this for initialization
	void Start () {
		rectTransform = this.GetComponent<RectTransform>();
	}

	public void FitInputFieldSize() {
		rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, textRectTransform.sizeDelta.y);

		Debug.Log("rectTransform.sizeDelta="+rectTransform.sizeDelta);
		Debug.Log(" textRectTransform.sizeDelta=" + textRectTransform.sizeDelta);
	}

}
