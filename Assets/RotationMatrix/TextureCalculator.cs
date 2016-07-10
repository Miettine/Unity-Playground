using UnityEngine;
using System.Collections;

public class TextureCalculator {

	static Vector2[] CalculateMatrix(float angleDeg) {
		//Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)), new Vector2(-1f * Mathf.Sin(angle), Mathf.Cos(angle)) };
		float angleRad = Mathf.Deg2Rad * angleDeg;

		Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)), new Vector2(-1f * Mathf.Sin(angleRad), Mathf.Cos(angleRad)) };
		return rotationMatrix;
	}

	public static Vector2[] GetRotatedUv(float angle, Vector2[] originalUv) {

		Vector2[] rotationMatrix = TextureCalculator.CalculateMatrix(-angle);

		Debug.Log(originalUv.Length);

		Vector2[] rotatedUv = new Vector2[originalUv.Length];

		for (int i = 0; i < originalUv.Length; i++) {
			rotatedUv[i].x = Vector2.Dot(rotationMatrix[0], originalUv[i]);
			rotatedUv[i].y = Vector2.Dot(rotationMatrix[1], originalUv[i]);
		}

		return rotatedUv;
	}
}
