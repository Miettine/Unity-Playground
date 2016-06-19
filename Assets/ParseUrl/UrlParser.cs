using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class UrlParser : MonoBehaviour {

	public Text parseableUiText;
	string parseableText;

	List<string> list = new List<string>();

	void Awake() {
		parseableText = parseableUiText.text;
	}

	// Use this for initialization
	void Start () {
		Regex urlRx =
			new Regex(@"(?<url>(http:|https:[/][/]|www.)([a-z]|[A-Z]|[0-9]|[/~?=&#+-])*)",
			RegexOptions.IgnoreCase);

		

		/*new Regex(@"(?<url>(http:|https:[/][/]|www.)([a-z]|[A-Z]|[0-9]|[/.]|[~]|[?]|[=]|[&]|[#]|[+]|[-])*)", */
		//Reader, in case you are not familiar with regular expressions, it lets you parse Url's out of the comment string




		MatchCollection matches = urlRx.Matches(parseableText);
		foreach (Match match in matches) {
			string foundMatch = match.Value;

			//string str = "1,5,12,34,";
			//string removecomma = str.Remove(str.Length - 1);
			//foundMatch = Regex.Replace(foundMatch, ".$", "");

			foundMatch.TrimEnd(foundMatch[foundMatch.Length - 1]);

			list.Add(foundMatch);
		}

		for (int i = 0; i<list.Count; i++) {
			Debug.Log(list[i]);
		}
	}
}
