using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuButtons : MonoBehaviour
{

    public GameObject accessMenu;
    public GameObject visualOnlyMode;
    public GameObject audioOnlyMode;
    public GameObject subtitlesOn;
    public GameObject XButtonParent;
    public GameObject originalButton;
    public GameObject accessX;
    public GameObject creditsPanel;

    public string mode;

    // Start is called before the first frame update
    public void onClickStart()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("levelSelect");

        //fade to black and fade into new scene
        //basically fade out here and new scene manages fade in
    }

    public void onClickAccessbility()
    {
        accessMenu.SetActive(true);
        accessX.SetActive(true);
        gameObject.SetActive(false);
    }

    public void onVisualSlider()
    {
        if (GetComponent<Slider>().value == 0)
        {
            GameObject.Find("AccessibilityManager").GetComponent<AccessManager>().visualOnlyMode = false;
        }
        else if (GetComponent<Slider>().value == 1)
        {
            GameObject.Find("AccessibilityManager").GetComponent<AccessManager>().visualOnlyMode = true;
        }
    }

    public void onAudioSlider()
    {
        if (GetComponent<Slider>().value == 0)
        {
            GameObject.Find("AccessibilityManager").GetComponent<AccessManager>().audioOnlyMode = false;
        }
        else if (GetComponent<Slider>().value == 1)
        {
            GameObject.Find("AccessibilityManager").GetComponent<AccessManager>().audioOnlyMode = true;
        }
    }

    public void subtitleSlider()
    {
        if (GetComponent<Slider>().value == 0)
        {
            GameObject.Find("AccessibilityManager").GetComponent<AccessManager>().subtitlesOn = false;
        }
        else if (GetComponent<Slider>().value == 1)
        {
            GameObject.Find("AccessibilityManager").GetComponent<AccessManager>().subtitlesOn = true;
        }
    }

    public void onClickX()
    {
        originalButton.SetActive(true);
        XButtonParent.SetActive(false);
        gameObject.SetActive(false);
    }

    

}
