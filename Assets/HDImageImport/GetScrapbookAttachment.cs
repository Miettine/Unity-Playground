/*
 * Copyright 2016, Gregg Tavares.
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are
 * met:
 *
 *     * Redistributions of source code must retain the above copyright
 * notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above
 * copyright notice, this list of conditions and the following disclaimer
 * in the documentation and/or other materials provided with the
 * distribution.
 *     * Neither the name of Gregg Tavares. nor the names of its
 * contributors may be used to endorse or promote products derived from
 * this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
 * "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
 * LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
 * A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
 * OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
 * LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
 * THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetScrapbookAttachment : MonoBehaviour {

	public Image spriteImage;
	
	public Text debugText;

	public void AddAttachmentOnClick() {
		// NOTE: gameObject.name MUST BE UNIQUE!!!!
		GetImage.GetImageFromUserAsync(gameObject.name, "ReceiveImage");
		///GetImage.GetImageFromUserAsync(gameObject.name, "ReceiveImage");
	}

	public void AddDebugText (string textIn) {
		debugText.text += textIn+" ; ";
	}

	static string s_dataUrlPrefix = "data:image/png;base64,";
	public void ReceiveImage(string dataUrl) {

		AddDebugText("ReceiveImage");

		if (dataUrl.StartsWith(s_dataUrlPrefix)) {
			AddDebugText("Prefix is correct");
			byte[] pngData = System.Convert.FromBase64String(dataUrl.Substring(s_dataUrlPrefix.Length));

			// Create a new Texture (or use some old one?)
			Texture2D imageFromComputer = new Texture2D(1, 1); // does the size matter?

			if (imageFromComputer.LoadImage(pngData)) {
				AddDebugText("decoding image");

				Sprite theSprite = Sprite.Create(imageFromComputer, new Rect(0, 0, imageFromComputer.width, imageFromComputer.height), new Vector2(0.5f, 0.5f));

				spriteImage.sprite = theSprite;

			} else {
				Debug.LogError("could not decode image");
				AddDebugText("could not decode image");
			}
		} else {
			Debug.LogError("Error getting image:" + dataUrl);
			AddDebugText("Error getting image");
			AddDebugText(dataUrl);
		}
	}
}
