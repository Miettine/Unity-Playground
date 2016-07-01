using UnityEngine;
using System.Collections;

public class RotationMatrix : MonoBehaviour {

	public float givenAngle = 25f;

	Mesh mMesh;

	// Use this for initialization
	void Start() {
		var meshFilter = GetComponent<MeshFilter>();
		mMesh = meshFilter.mesh;
		Rotate(givenAngle);
	}

	Vector2[] CalculateMatrix (float angleDeg) {
		//Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)), new Vector2(-1f * Mathf.Sin(angle), Mathf.Cos(angle)) };
		float angleRad = Mathf.Deg2Rad*angleDeg;

		Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)), new Vector2(-1f * Mathf.Sin(angleRad), Mathf.Cos(angleRad)) };
		return rotationMatrix;
	}

	void Rotate(float angle) {
		Vector2[] rotationMatrix= CalculateMatrix(angle);

		Vector2[] rotatedUv = mMesh.uv;

		for (int i = 0; i < rotatedUv.Length; i++) {
			rotatedUv[i].x = Vector2.Dot(rotationMatrix[0], mMesh.uv[i]);
			rotatedUv[i].y = Vector2.Dot(rotationMatrix[1], mMesh.uv[i]);
		}

		mMesh.uv = rotatedUv;
	}
}
