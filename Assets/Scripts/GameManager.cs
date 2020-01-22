using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score;

    public AudioSource audiosrc;

    public AudioClip[] menumusic;

    public bool audioOnlyMode;
    public bool visualOnlyMode;
    public bool subtitlesOn;

    public GameObject accessManager;

    // Start is called before the first frame update
    void Start()
    {
        checkAccessSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkAccessSettings()
    {
        audioOnlyMode = accessManager.GetComponent<AccessManager>().audioOnlyMode;
        visualOnlyMode = accessManager.GetComponent<AccessManager>().visualOnlyMode;
        subtitlesOn = accessManager.GetComponent<AccessManager>().subtitlesOn;
    }
}
