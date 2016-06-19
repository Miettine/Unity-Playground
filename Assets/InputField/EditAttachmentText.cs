using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EditAttachmentText : MonoBehaviour {
	public InputField inputField;
	public Text attachmentText;
	public ScrollRect scrollRect;

	// Use this for initialization
	void Start () {
		inputField.gameObject.SetActive(false);
	}

	public void AttachmentTextOnClick() {
		inputField.gameObject.SetActive(true);

		inputField.text = attachmentText.text;

		//RectTransform inputFieldRect = inputField.GetComponent<RectTransform>();
		//RectTransform attachmentTextRect = attachmentText.GetComponent<RectTransform>();

		//float inputFieldHeight = attachmentTextRect.sizeDelta.y; //The input field should be at least as high as the attachment Text


		/*if (inputFieldHeight < fontSize*5) {
			inputFieldHeight += fontSize * 10; 
		} else {*/
		//	inputFieldHeight += fontSize * 3; //As an approximation, adding multiples of the font size.
		//}

		//int fontSize = attachmentText.fontSize;

		//LayoutElement layoutElement = attachmentText.GetComponent<LayoutElement>();
		//layoutElement.enabled = true;
		//layoutElement.preferredHeight = attachmentTextRect.sizeDelta.y + fontSize * 3;


		attachmentText.color = new Color(1f, 1f, 1f, 0f);
		/* ~Miettine: This is the only way to make the text correctly disappear and the input field appear.
		 * The input field is so hard to scale and keep it correctly sized.
		 *  I came up with this solution after about 3 hours of work. 
		 *  Keep that in mind if you are thinking about changing this line.
		*/

		scrollRect.verticalNormalizedPosition = 0f;

		inputField.ActivateInputField();

	}

	public void InputFieldOnValueChanged() {
		scrollRect.verticalNormalizedPosition = 0f;
		attachmentText.text = inputField.text;
	}

	public void InputFieldOnEndEdit() {
		inputField.gameObject.SetActive(false);
	
		//attachmentText.GetComponent<LayoutElement>().preferredHeight = -1f;

		inputField.DeactivateInputField();

		attachmentText.color = new Color(1f, 1f, 1f, 1f);
	}
}
