using UnityEngine;
using System.Collections;

public class RotationMatrix : MonoBehaviour {

	
}


/*
 * 
		public int givenAngle = 25;

	Mesh m_Mesh;

	// Use this for initialization
	void Start() {
		var meshFilter = GetComponent<MeshFilter>();
		m_Mesh = meshFilter.mesh;

		Rotate(-givenAngle);
	}


	Vector2[] CalculateMatrix(float angleDeg) {
		//Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)), new Vector2(-1f * Mathf.Sin(angle), Mathf.Cos(angle)) };
		float angleRad = Mathf.Deg2Rad * angleDeg;

		Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)), new Vector2(-1f * Mathf.Sin(angleRad), Mathf.Cos(angleRad)) };
		return rotationMatrix;
	}

	void Rotate(float angle) {

		Vector2[] rotationMatrix = CalculateMatrix(angle);

		Vector2[] rotatedUv = m_Mesh.uv;

		for (int i = 0; i < rotatedUv.Length; i++) {
			rotatedUv[i].x = Vector2.Dot(rotationMatrix[0], m_Mesh.uv[i]);
			rotatedUv[i].y = Vector2.Dot(rotationMatrix[1], m_Mesh.uv[i]);
		}

		m_Mesh.uv = rotatedUv;
	}
 */
/*
 * 
   public int givenAngle = 25;

   // Use this for initialization
   void Start() {
	   var meshFilter = GetComponent<MeshFilter>();
	   var m_Mesh = meshFilter.mesh;

	   var vectors = GetRotatedUv(-givenAngle, m_Mesh.uv);
	   m_Mesh.uv = vectors;
   }


   Vector2[] CalculateMatrix(float angleDeg) {
	   //Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)), new Vector2(-1f * Mathf.Sin(angle), Mathf.Cos(angle)) };
	   float angleRad = Mathf.Deg2Rad * angleDeg;

	   Vector2[] rotationMatrix = { new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)), new Vector2(-1f * Mathf.Sin(angleRad), Mathf.Cos(angleRad)) };
	   return rotationMatrix;
   }

   Vector2[] GetRotatedUv(float angle, Vector2[] originalUV) {

	   Vector2[] rotationMatrix = CalculateMatrix(angle);

	   Vector2[] rotatedUv = originalUV;

	   for (int i = 0; i < rotatedUv.Length; i++) {
		   rotatedUv[i].x = Vector2.Dot(rotationMatrix[0], originalUV[i]);
		   rotatedUv[i].y = Vector2.Dot(rotationMatrix[1], originalUV[i]);
	   }

	   return rotatedUv;
   }
 * */
