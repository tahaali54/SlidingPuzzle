using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timer;
    private float t = 90;
    public bool complete = false;

    public static Timer Instance;
    void Start()
    {
        // Register the singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of Timer!");
        }
        Instance = this;
        t = string.IsNullOrEmpty(timer.text) ? 90 : float.Parse(timer.text);
    }
    

	void Update ()
	{
        if (timer.text != "0" && complete == false)
            DecrementTime();
    }

    private void DecrementTime()
    {
        t -= Time.deltaTime;
        timer.text = Mathf.RoundToInt(t).ToString();
    }


}
