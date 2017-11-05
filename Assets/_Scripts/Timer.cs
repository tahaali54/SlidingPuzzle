using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	
	public Text timer;
	private float t = 90;

	void Update ()
	{
		t -= Time.deltaTime;
		timer.text = Mathf.RoundToInt (t).ToString();
	}


}
