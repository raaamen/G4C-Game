using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class tutorialScript : MonoBehaviour
{

    public AudioClip[] instructionspeak;
    public AudioClip[] comicspeak;
    public AudioSource audioplr;

    public GameObject scrollNote;
    public GameObject accessManage;
    public ScrollNotes scr;

    public TextMeshPro text;

    public TextAsset textAsset;

    public List<string> dialogueList;

    public bool skiptext = false;

    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().enabled = false;
        accessManage = GameObject.Find("AccessibilityManager");
        scr = scrollNote.GetComponent<ScrollNotes>();
        var lines = textAsset.text.Split("\n"[0]);
        foreach (var obj in lines)
        {
            dialogueList.Add(obj); 
        }
        StartCoroutine("instructText");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            skiptext = true;
        }
        
    }
    public IEnumerator instructText()
    {
        Debug.Log("the text is going");
        
        foreach (var item in instructionspeak)
        {
            if (accessManage.GetComponent<AccessManager>().subtitlesOn)
            {
                GetComponent<TextMeshProUGUI>().enabled = true;
                GetComponent<TextMeshProUGUI>().text = dialogueList[i];
            }
            GetComponent<AudioSource>().clip = item;
            GetComponent<AudioSource>().Play();
            yield return new WaitWhile(isAudioPlaying);
            i++;
            if (skiptext)
            {
                GetComponent<AudioSource>().Stop();
                break;
            }
        }
        scr.canStart = true;
        GetComponent<TextMeshProUGUI>().gameObject.SetActive(false);
        yield return null;
    }

    public bool isAudioPlaying()
    {
        Debug.Log("checking audio");
        if (GetComponent<AudioSource>().isPlaying) return true;
        else return false;
    }


}
