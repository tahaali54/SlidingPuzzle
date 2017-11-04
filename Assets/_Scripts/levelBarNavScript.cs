using UnityEngine;
using System.Collections;

public class levelBarNavScript : MonoBehaviour {

	public GameObject twoXtwo, threeXthree, fourXfour;
	public GameObject help;

	public void showLevels (string bName)
	{
		SoundEffectsHelper.Instance.MakeButtonClickSound ();
		if (bName == "2x2") 
		{
			twoXtwo.SetActive(true);
			threeXthree.SetActive(false);
			fourXfour.SetActive(false);
		}
		else if (bName == "3x3") 
		{
			twoXtwo.SetActive(false);
			threeXthree.SetActive(true);
			fourXfour.SetActive(false);
		}
		else if (bName == "4x4") 
		{
			twoXtwo.SetActive(false);
			threeXthree.SetActive(false);
			fourXfour.SetActive(true);
		}

		if (help != null)
			help.SetActive (false);
	}
}
