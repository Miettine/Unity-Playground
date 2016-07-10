using UnityEngine;
using System.Collections;

public class MatrixRotator :MonoBehaviour{

	public static Vector2[] CalculateMatrix(float _angleDeg) {
		//Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)), new Vector2(-1f * Mathf.Sin(angle), Mathf.Cos(angle)) };
		float angleRad = Mathf.Deg2Rad * _angleDeg;

		Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)), new Vector2(-1f * Mathf.Sin(angleRad), Mathf.Cos(angleRad)) };
		return rotationMatrix;
	}

	public static Vector2[] GetRotatedUv(float _angle, Vector2[] _originalUv) {

		Vector2[] rotationMatrix = MatrixRotator.CalculateMatrix(_angle);

		Debug.Log(_originalUv.Length);

		Vector2[] rotatedUv = new Vector2[_originalUv.Length];

		for (int i = 0; i < _originalUv.Length; i++) {
			rotatedUv[i].x = Vector2.Dot(rotationMatrix[0], _originalUv[i]);
			rotatedUv[i].y = Vector2.Dot(rotationMatrix[1], _originalUv[i]);
		}

		return rotatedUv;
	}

	public static void RotateUv(float _angle, Mesh _mesh) {


		Vector2[] originalUv = _mesh.uv;

		Vector2[] rotatedUv = MatrixRotator.GetRotatedUv(-_angle, originalUv);

		_mesh.uv = rotatedUv;
	}
	/*
	public static void RotateUv(float _angle, GameObject _gameObject) {

		Mesh mesh = _gameObject.GetComponent<Mesh>();

		Vector2[] originalUv = mesh.uv;

		Vector2[] rotatedUv = MatrixRotator.GetRotatedUv(_angle, originalUv);

		mesh.uv = rotatedUv;
	}*/
}
