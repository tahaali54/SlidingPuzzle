using UnityEngine;
using System.Collections;

public class navigationScript : MonoBehaviour {

	public string loadLevelVar1;
    private int temp_LevelLockStatus;
    private int levelToResumeFrom;
    void Start()
    {
        levelToResumeFrom = PlayerPrefs.GetInt("Resume From", 1);
        setResumePointer();

        //TO-DO: Use this logic when locking levels 

        //PlayerPrefs.SetInt("Level 1", 1);
        //for (int i = 1; i <= 9; i++)
        //{
        //    temp_LevelLockStatus = PlayerPrefs.GetInt("Level " + i, 0);
        //}
    }
    public void setResumePointer()
    {
        string caseSwitch = Application.loadedLevelName;

        switch (caseSwitch)
        {
            case "Level 1":
                PlayerPrefs.SetInt("Resume From", 1);
                break;
            case "Level 2":
                PlayerPrefs.SetInt("Resume From", 2);
                break;
            case "Level 3":
                PlayerPrefs.SetInt("Resume From", 3);
                break;
            case "Level 4":
                PlayerPrefs.SetInt("Resume From", 4);
                break;
            case "Level 5":
                PlayerPrefs.SetInt("Resume From", 5);
                break;
            case "Level 6":
                PlayerPrefs.SetInt("Resume From", 6);
                break;
            case "Level 7":
                PlayerPrefs.SetInt("Resume From", 7);
                break;
            case "Level 8":
                PlayerPrefs.SetInt("Resume From", 8);
                break;
            case "Level 9":
                PlayerPrefs.SetInt("Resume From", 9);
                break;
        }
    }
    public void loadNextLevel()
    {
        try
        {
            int temp_NextLevel = PlayerPrefs.GetInt("Resume From", 1) + 1;
            StartCoroutine(loadNextLevelAsync(temp_NextLevel));
        }
        catch (System.Exception)
        {
            Application.LoadLevel("MENU");
        }
    }
    IEnumerator loadNextLevelAsync(int temp_NextLevel)
    {
        SoundEffectsHelper.Instance.MakeButtonClickSound();
        yield return new WaitForSeconds(0.11f);
        Application.LoadLevel("Level " + temp_NextLevel);
    }
    public void resumeLevel()
    {
        StartCoroutine(resumeLevelAsync());
    }
    IEnumerator resumeLevelAsync()
    {
        SoundEffectsHelper.Instance.MakeButtonClickSound();
        yield return new WaitForSeconds(0.11f);
        Application.LoadLevel("Level " + levelToResumeFrom);
    }
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