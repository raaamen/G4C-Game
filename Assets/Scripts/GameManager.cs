using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int score;

    public TextMeshProUGUI scoretxt;

    public AudioSource audiosrc;

    public AudioClip[] menumusic;

    public bool audioOnlyMode;
    public bool visualOnlyMode;
    public bool subtitlesOn;

    public GameObject accessManager;
    public GameObject levelManager;

    // Start is called before the first frame update

    private void Awake()
    {

        accessManager = GameObject.Find("AccessibilityManager");
        levelManager = GameObject.Find("LevelSelectedManager");
    }
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

    public void checkLvlLoad()
    {

    }

    public void updateScore()
    {
        scoretxt.text = "Score: "+score;
    }

}
