using UnityEngine;
using System.Collections;

public class BetterRotationMatrix : MonoBehaviour {

	//TODO: Figure out why this code doesn't work, and the commented version below does
	public int givenAngle = 25;

	// Use this for initialization
	void Start() {
		MeshFilter meshFilter = GetComponent<MeshFilter>();
		Mesh m_Mesh = meshFilter.mesh;

		Vector2[] vectors = GetRotatedUv(givenAngle, m_Mesh.uv);
		m_Mesh.uv = vectors;

		Destroy(this);
	}

	Vector2[] GetRotatedUv(float angle, Vector2[] originalUv) {

		Vector2[] rotationMatrix = MatrixRotator.CalculateMatrix(-angle);

		Debug.Log(originalUv.Length);

		Vector2[] rotatedUv = new Vector2[originalUv.Length];

		for (int i = 0; i < originalUv.Length; i++) {
			rotatedUv[i].x = Vector2.Dot(rotationMatrix[0], originalUv[i]);
			rotatedUv[i].y = Vector2.Dot(rotationMatrix[1], originalUv[i]);
		}

		return rotatedUv;
	}
}
