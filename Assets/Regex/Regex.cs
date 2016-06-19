using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;


public class Regex : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string pattern=@"[0-9a-z]+$";
		Match match = System.Text.RegularExpressions.Regex.Match("a_swimmipng_duckpng.png", pattern,RegexOptions.IgnoreCase);
		Debug.Log(match.ToString());

	
		Match match2 = System.Text.RegularExpressions.Regex.Match("a_swimmipng_duckpng.PNG", pattern, RegexOptions.IgnoreCase);
		Debug.Log(match2.ToString());

		Match match3 = System.Text.RegularExpressions.Regex.Match("a_swimmipng_duckpng.JPG", pattern, RegexOptions.IgnoreCase);
		Debug.Log(match3.ToString());

		Match match4 = System.Text.RegularExpressions.Regex.Match("a_swimmipng_duckpng.jpeg", pattern, RegexOptions.IgnoreCase);
		Debug.Log(match4.ToString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
