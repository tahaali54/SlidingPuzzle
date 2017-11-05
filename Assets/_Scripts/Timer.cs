using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timer;
    private float t = 90;
    void Start()
    {
        t = string.IsNullOrEmpty(timer.text) ? 90 : float.Parse(timer.text);
    }
    

	void Update ()
	{
        if (timer.text != "0")
            DecrementTime();
    }

    private void DecrementTime()
    {
        t -= Time.deltaTime;
        timer.text = Mathf.RoundToInt(t).ToString();
    }


}
