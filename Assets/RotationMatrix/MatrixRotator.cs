using UnityEngine;
using System.Collections;

public class MatrixRotator : MonoBehaviour {

	public static Vector2[] CalculateMatrix(float angleDeg) {
		//Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)), new Vector2(-1f * Mathf.Sin(angle), Mathf.Cos(angle)) };
		float angleRad = Mathf.Deg2Rad * angleDeg;

		Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)), new Vector2(-1f * Mathf.Sin(angleRad), Mathf.Cos(angleRad)) };
		return rotationMatrix;
	}
}
