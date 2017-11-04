using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LB_Script : MonoBehaviour {

	public Text l1,l2,l3,l4,l5;
	// Use this for initialization
	void Start () {
		showScores ();
	}
	
public void showScores()
	{
		l1.text += PlayerPrefs.GetFloat ("l1", 1000).ToString("n1");
		l2.text += PlayerPrefs.GetFloat ("l2", 1000).ToString("n1");
		l3.text += PlayerPrefs.GetFloat ("l3", 1000).ToString("n1");
		l4.text += PlayerPrefs.GetFloat ("l4", 1000).ToString("n1");
		l5.text += PlayerPrefs.GetFloat ("l5", 1000).ToString("n1");
	}
}
