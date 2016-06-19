using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextureConverter : MonoBehaviour {

	public RawImage rawImage;
	public Texture2D rawImageTexture;
	public Image image;

	// Use this for initialization
	void Start () {
		//rawImageTexture =  (Texture2D) rawImage.texture as Texture2D;
		//image.sprite = Sprite.Create(rawImageTexture, new Rect(0, 0, rawImageTexture.width, rawImageTexture.height), new Vector2(0.5f, 0.5f));
	}

	public static Sprite Texture2DToSprite(Texture2D textureIn) {
		Sprite sprite = Sprite.Create(textureIn, new Rect(0, 0, textureIn.width, textureIn.height), new Vector2(0.5f, 0.5f));
		return sprite;
	}
	
	public void ChangeSpriteWidth(float amount) {
		RectTransform rectTransform = image.rectTransform;
		rectTransform.sizeDelta=new Vector2(rectTransform.rect.width + amount, rectTransform.rect.height);
	}
	
	public void ChangeSpriteHeight(float amount) {
		RectTransform rectTransform = image.rectTransform;
		rectTransform.sizeDelta = new Vector2(rectTransform.rect.width, rectTransform.rect.height + amount);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
