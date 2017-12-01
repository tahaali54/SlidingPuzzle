using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MusicControl : MonoBehaviour
{

    public GameObject MUSIC_ICON;

    public bool CanMute;

    public Sprite skin1, skin2;

    public void toggleSound()
    {
        StartCoroutine(ToggleSoundAsync());
    }

    IEnumerator ToggleSoundAsync()
    {
        if (CanMute)
        {
            AudioListener.pause = true;
            MUSIC_ICON.GetComponent<Image>().sprite = skin1;
            CanMute = false;            
        }
        else
        {
            AudioListener.pause = false;
            SoundEffectsHelper.Instance.MakeButtonClickSound();
            yield return new WaitForSeconds(0.11f);
            MUSIC_ICON.GetComponent<Image>().sprite = skin2;
            CanMute = true;
        }
    }

    void Start()
    {
        if (AudioListener.pause)
        {
            MUSIC_ICON.GetComponent<Image>().sprite = skin1;
            CanMute = false;
        }
        else
        {
            CanMute = true;
            MUSIC_ICON.GetComponent<Image>().sprite = skin2;
        }
    }


}

