using UnityEngine;
using System.Collections;

public class Level_Sol : MonoBehaviour {

	public GameObject lvlEnd;
	public GameObject[] St = new GameObject[5];
	public Vector3[] Tp = new Vector3[5];
	public bool[] Solved = new bool[5];


	void Update () 
	{
		for (int i=0; i<St.Length; i++) 
		{
			if (St[i].transform.position == Tp[i])
				Solved[i] = true;
			else
				Solved[i] = false;
		}
		Chk_Sol ();
		if (Input.GetKey("escape"))
			//Application.Quit();
			Application.LoadLevel("MENU");

	}
	public void Chk_Sol()
	{
		int x=0;
		while (x != Solved.Length - 1) 
		{
		if (Solved[x] == true)
				x++;
			else
				return;
		}
		lvlEnd.SetActive (true);
		Time.timeScale = 0;
		//CheckHighScore (Timer.Instance.t, Timer.Instance.LEVEL);
	}

	void CheckHighScore(float t, string LEVEL)
	{
		float temp = PlayerPrefs.GetFloat (LEVEL, 1000);
		if (t < temp) {
			PlayerPrefs.SetFloat (LEVEL, t);
			print (PlayerPrefs.GetFloat (LEVEL, 1000));
		}
	}
}
