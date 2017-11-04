using UnityEngine;
using System.Collections;

public class Level_Complete : MonoBehaviour {

	public string Level_Name;

	public void OnMouseUp()
	{
		Time.timeScale = 1;
		Application.LoadLevel (Level_Name);
	}

	public void goBack()
	{
		Application.Quit();
	}
}
