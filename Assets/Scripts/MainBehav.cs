using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainBehav : MonoBehaviour {
	public TMP_Text MainText;

	public void ButtonPressed() {
		Debug.Log("asdf");
		MainText.text = Time.time.ToString();
	}
}
