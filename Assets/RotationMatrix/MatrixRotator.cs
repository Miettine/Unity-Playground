using UnityEngine;
using System.Collections;

public class MatrixRotator : MonoBehaviour {

	public int givenAngle = 25;

public 	GameObject rotatedGameObject;

	void Start() {

		rotatedGameObject.GetComponent<Mesh>().uv = GetRotatedUv(givenAngle, rotatedGameObject.GetComponent<Mesh>().uv);

	}

	Vector2[] GetRotatedUv(float _angle, Vector2[] _originalUv) {

		Vector2[] rotationMatrix = CalculateMatrix(_angle);

		Debug.Log(_originalUv.Length);

		Vector2[] rotatedUv = new Vector2[_originalUv.Length];

		for (int i = 0; i < _originalUv.Length; i++) {
			rotatedUv[i].x = Vector2.Dot(rotationMatrix[0], _originalUv[i]);
			rotatedUv[i].y = Vector2.Dot(rotationMatrix[1], _originalUv[i]);
		}

		return rotatedUv;
	}

	Vector2[] CalculateMatrix(float _angleDeg) {
		//Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)), new Vector2(-1f * Mathf.Sin(angle), Mathf.Cos(angle)) };
		float angleRad = Mathf.Deg2Rad * _angleDeg;

		Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)), new Vector2(-1f * Mathf.Sin(angleRad), Mathf.Cos(angleRad)) };
		return rotationMatrix;
	}

	
	void RotateUv(float _angle, GameObject _gameObject) {

		Mesh mesh = _gameObject.GetComponent<Mesh>();

		Vector2[] originalUv = mesh.uv;

		Vector2[] rotatedUv = GetRotatedUv(_angle, originalUv);

		mesh.uv = rotatedUv;
	}
}
