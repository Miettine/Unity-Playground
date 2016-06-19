using UnityEngine;
using System;
using System.Collections;

//using GB.Json;
//using GB.Json.Linq;
using System.Collections.Generic;

public class Jason : MonoBehaviour {

	public string jsonData;

	// Use this for initialization
	IEnumerator Start() {
		string apiAddress = "...";

		Uri address = new Uri(apiAddress );

		WWW www = new WWW(address.ToString());

		yield return www;

		string jsonData = www.text;

		Debug.Log(jsonData);

		try {
			//HotspotsRootObject rootObject = JsonConvert.DeserializeObject<HotspotsRootObject>(jsonData);

			//Debug.Log("Errors: " + rootObject.Error);

			//List<HotspotData> hotspots = rootObject.Data;

			//scrapbookController.GiveHotspots(rootObject.Data); //Tallentaa listan omaan datajäseneen ja instansioi ne spotit.

			//Debug.Log("Got " + hotspots.Count + " hotspots");

			//for (int i = 0; i < hotspots.Count; i++) {
			//	Debug.Log("Object #" + i + ": " + hotspots[i].Id + " ; " +
			//	hotspots[i].AttachmentText + " ; " +
			//	hotspots[i].CreationDate + " ; " +
			//	hotspots[i].Layer + " ; " +
			//	hotspots[i].ParentGuid + " ; " +
			//	hotspots[i].ProjectGuid + " ; " +
			//	hotspots[i].XCoord + " ; " +
			//	hotspots[i].YCoord + " ; " +
			//	hotspots[i].ZCoord + " ; " +
			//	hotspots[i].RciEntityId);

			//}
		} catch(Exception e) {
			Debug.Log("Exception:"+ e);
		} finally {
			Debug.Log("It dun did it!");
		}


		//JObject jObject = JObject.Parse(jsonData);

	}
}
/*
public class HotspotData {
	public HotspotData(string json) {
		JObject jObject = JObject.Parse(json);
		JToken hotspotData = jObject["data"];
		new HotspotData()
		AttachmentText = (string)hotspotData["ATTACHMENTTEXT"];
	}

	public int Id { get; set; }
	public string AttachmentText { get; set; }
	public string CreationDate { get; set; }
	public int Layer { get; set; }
	public string ParentGuid { get; set; }
	public string ProjectGuid { get; set; }
	public float XCoord { get; set; }
	public float YCoord { get; set; }
	public float ZCoord { get; set; }
	public int RciEntityId { get; set; }
}

*/

class HotspotsRootObject {
	//[JsonProperty("error")]
	//public string Error { get; set; }
	//[JsonProperty("data")]
	//public List<HotspotData> Data { get; set; }
}

class HotspotData {
	//[JsonProperty("id")]
	//public int Id { get; set; }

	//[JsonProperty("ATTACHMENTTEXT")]
	//public string AttachmentText { get; set; }

	//[JsonProperty("CREATIONDATE")]
	//public string CreationDate { get; set; }

	//[JsonProperty("Layer")]
	//public int Layer { get; set; }

	//[JsonProperty("PARENTGUID")]
	//public string ParentGuid { get; set; }

	//[JsonProperty("PROJECTGUID")]
	//public string ProjectGuid { get; set; }

	//[JsonProperty("XCOORD")]
	//public float XCoord { get; set; }

	//[JsonProperty("YCOORD")]
	//public float YCoord { get; set; }

	//[JsonProperty("ZCOORD")]
	//public float ZCoord { get; set; }

	//[JsonProperty("RCIENTITY_ID")]
	//public int RciEntityId { get; set; }

}
