using UnityEngine;
using System.Collections;

public class TextureRotator : MonoBehaviour {

	public int givenAngle = 25;

	public GameObject rotatedObject;

	void Start() {
		RotateTexture(rotatedObject, givenAngle);
    }

	void RotateTexture(GameObject _gameobject ,float _angle) {
		MeshFilter meshFilter = _gameobject.GetComponent<MeshFilter>();
		Mesh m_Mesh = meshFilter.mesh;

		Vector2[] vectors = TextureCalculator.GetRotatedUv(givenAngle, m_Mesh.uv);
		m_Mesh.uv = vectors;
	}
}
