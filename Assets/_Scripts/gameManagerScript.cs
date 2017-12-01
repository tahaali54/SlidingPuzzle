using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameManagerScript : MonoBehaviour {

    public GameObject ExitButton;
    public GameObject NextButton;
    public GameObject[] orignalImgPlaces = new GameObject[16];
	private Vector3[] tempImgPostions;
	private Vector3[] origImgPostions;
	public GameObject EndPannel;
    public Text timeEndText;
    public bool solved = false;

    public static gameManagerScript Instance;

    void Start () 
	{
        solved = false;
        // Register the singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of Timer!");
        }
        Instance = this;

        int len = orignalImgPlaces.Length;
		tempImgPostions = new Vector3[len];
		origImgPostions = new Vector3[len];

		for (int a=0; a<orignalImgPlaces.Length; a++) 
		{
			tempImgPostions[a] = orignalImgPlaces[a].transform.position;
		}

		for (int c=0; c<orignalImgPlaces.Length; c++) 
		{
			origImgPostions[c] = tempImgPostions[c];
		}
		tempImgPostions = reshuffle (tempImgPostions);

		scrambleImgPlaces2();
	}

	private Vector3[] reshuffle(Vector3[] ballotedNumbers2)
	{
		for (int t = 1; t < ballotedNumbers2.Length; t++ )
		{
			Vector3 tmp = ballotedNumbers2[t];
			int r = Random.Range(t, ballotedNumbers2.Length);
			ballotedNumbers2[t] = ballotedNumbers2[r];
			ballotedNumbers2[r] = tmp;
		}
		return ballotedNumbers2;
	}

	private void scrambleImgPlaces ()
	{

		for (int z=0; z<orignalImgPlaces.Length; z++) 
		{
			orignalImgPlaces[z].transform.position = tempImgPostions[z];
		}
	}

	private void scrambleImgPlaces2 ()
	{
		int count2 = Random.Range(1, 3);
		int count1 = 0;
		Debug.Log (count2);
		for (int j=0; j<orignalImgPlaces.Length*count2; j++) 
		{
			if (count1 >= orignalImgPlaces.Length)
			{
				count1 = count1 - orignalImgPlaces.Length;
			}
			if(Mathf.RoundToInt(Vector3.Distance(orignalImgPlaces[count1].transform.position,this.transform.position)+0.1f)==1 )
			{
				Vector3 temp1;
				Vector3 temp2;
				
				temp1   = orignalImgPlaces[count1].transform.position;
				temp1.x = this.transform.position.x;
				temp1.y = this.transform.position.y;
				
				temp2   = this.transform.position;
				temp2.x = orignalImgPlaces[count1].transform.position.x;
				temp2.y = orignalImgPlaces[count1].transform.position.y;
				
				orignalImgPlaces[count1].transform.position = temp1;
				this.transform.position = temp2;
			}
			count1++;
		}
	}

	void Update()
	{
		//Debug.Log("I was clicked");
		int counter = 0;
		for (int x=0; x<orignalImgPlaces.Length; x++) 
		{
			//print (orignalImgPlaces[x].transform.position + " " + origImgPostions[x] );
			if (Mathf.RoundToInt(orignalImgPlaces[x].transform.position.x) == Mathf.RoundToInt(origImgPostions[x].x) && Mathf.RoundToInt(orignalImgPlaces[x].transform.position.y) == Mathf.RoundToInt(origImgPostions[x].y))
			{
				print(orignalImgPlaces[x].name + " is in correct position!" );
				counter++;
			}
		}
		if (counter == (orignalImgPlaces.Length))
        {
            EndPannel.SetActive(true);
            Timer.Instance.complete = true;
            solved = true;
        }
		else 
		{
			EndPannel.SetActive (false);
			counter = 0;
		}
        if(solved && Application.loadedLevelName != "Level 9")
        {
            ExitButton.SetActive(false);
            NextButton.SetActive(true);
        }
	}
}
