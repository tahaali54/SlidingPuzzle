using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timer;
    private float t = 90;
    private void Start()
    {
        t = string.IsNullOrEmpty(timer.text) ? 90 : float.Parse(timer.text);
    }
    

	void Update ()
	{
		t -= Time.deltaTime;
		timer.text = Mathf.RoundToInt (t).ToString();
	}


}
