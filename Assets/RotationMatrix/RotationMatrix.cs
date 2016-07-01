using UnityEngine;
using System.Collections;

public class RotationMatrix : MonoBehaviour {

	// Use this for initialization
	void Start() {
		var meshFilter = GetComponent<MeshFilter>();
		var mesh = meshFilter.mesh;
		var vertices = mesh.vertices;

		Debug.Log(vertices);
		/*uvMap[0] = Vector2.zero;
		meshFilter.mesh.uv = uvMap;*/

		Vector2[] rotatedUv = new Vector2[vertices.Length];
		for (int i = 0, y = 0; y <= ySize; y++) {
			for (int x = 0; x <= xSize; x++, i++) {
				rotatedUv[i] = new Vector2(x / xSize, y / ySize);
			}
		}

		mesh.uv = rotatedUv;

	}

	// Update is called once per frame
	void Update() {

	}
}
