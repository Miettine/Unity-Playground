using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class UrlParser : MonoBehaviour {

	public Text parseableUiText;
	string parseableText;

	//List<string> list = new List<string>();

	void Awake() {
		//parseableText = parseableUiText.text;
	}


	void Start() {
		//TODO: Figure out why it insults me about Regex not existing in the namespace.

		//Regex System.Text.urlRx =
		//	new System.Text.Regex(@"(?<url>(http:|https:[/][/]|www.)([a-z]|[A-Z]|[0-9]|[/~?=&#+-])*)"
		//);



		/*new Regex(@"(?<url>(http:|https:[/][/]|www.)([a-z]|[A-Z]|[0-9]|[/.]|[~]|[?]|[=]|[&]|[#]|[+]|[-])*)", */
		//Reader, in case you are not familiar with regular expressions, it lets you parse Url's out of the comment string




		//MatchCollection matches = urlRx.Matches(parseableText);
		//foreach (Match match in matches) {
		//	string foundMatch = match.Value;

		//	//string str = "1,5,12,34,";
		//	//string removecomma = str.Remove(str.Length - 1);
		//	//foundMatch = Regex.Replace(foundMatch, ".$", "");

		//	foundMatch.TrimEnd(foundMatch[foundMatch.Length - 1]);

		//	list.Add(foundMatch);
		//}

		//for (int i = 0; i < list.Count; i++) {
		//	Debug.Log(list[i]);
		//}
	}
}
