using UnityEngine;
using System.Collections;

public class navigationScript : MonoBehaviour {

	public string loadLevelVar1;

	public void restartLevel()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	public void navigateToNextLevel()
	{
		StartCoroutine(navigateToNextLevel2());

	}
	public void navigateToExit()
	{
		StartCoroutine(navigateToExit2());
	}

	IEnumerator navigateToNextLevel2() {
		SoundEffectsHelper.Instance.MakeButtonClickSound ();
		yield return new WaitForSeconds(0.11f);
		Application.LoadLevel (loadLevelVar1);
	}
	IEnumerator navigateToExit2() {
		SoundEffectsHelper.Instance.MakeButtonClickSound ();
		yield return new WaitForSeconds(0.11f);
		Application.Quit();
	}

}