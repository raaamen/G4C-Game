using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class comicScript : MonoBehaviour
{
    public AudioClip[] instructionspeak;
    public AudioClip[] comicspeak;
    public AudioSource audioplr;

    public TextAsset textAsset;

    public GameObject accessManage;

    public Sprite[] comicHolder;
    public GameObject comic;

    public TextMeshPro text;

    public List<string> dialogueList;

    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().enabled = false;
        accessManage = GameObject.Find("AccessibilityManager");
      
        var lines = textAsset.text.Split("\n"[0]);
        foreach (var obj in lines)
        {
            dialogueList.Add(obj);
        }
        StartCoroutine("instructText");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("gameScene");
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
            comic.GetComponent<SpriteRenderer>().sprite = comicHolder[i];
            GetComponent<AudioSource>().clip = item;
            GetComponent<AudioSource>().Play();
            yield return new WaitWhile(isAudioPlaying);
            i++;
            
        }
        SceneManager.LoadScene("gameScene");
        yield return null;
    }

    public bool isAudioPlaying()
    {
        Debug.Log("checking audio");
        if (GetComponent<AudioSource>().isPlaying) return true;
        else return false;
    }
}
