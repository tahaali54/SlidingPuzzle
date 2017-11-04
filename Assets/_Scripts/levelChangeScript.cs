using UnityEngine;
using System.Collections;

public class levelChangeScript : MonoBehaviour {

	public string levelVar1, levelVar2, levelVar3;

	public void loadVar1()
	{
		StartCoroutine(loadVar_1());

	}
	public void loadVar2()
	{
		StartCoroutine(loadVar_2());
	}
	public void loadVar3()
	{
		StartCoroutine(loadVar_3());
	}

	IEnumerator loadVar_1() {
		SoundEffectsHelper.Instance.MakeButtonClickSound ();
		yield return new WaitForSeconds(0.11f);
		Application.LoadLevel (levelVar1);
	}
	IEnumerator loadVar_2() {
		SoundEffectsHelper.Instance.MakeButtonClickSound ();
		yield return new WaitForSeconds(0.11f);
		Application.LoadLevel (levelVar2);
	}
	IEnumerator loadVar_3() {
		SoundEffectsHelper.Instance.MakeButtonClickSound ();
		yield return new WaitForSeconds(0.11f);
		Application.LoadLevel (levelVar3);
	}
}
