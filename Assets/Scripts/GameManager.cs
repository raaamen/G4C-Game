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
    public GameObject buttonControl;
    public ScrollNotes notesScript;
    public ButtonController buttonscript;
    public GameObject visualblock;

    // Start is called before the first frame update

    private void Awake()
    {
        buttonscript = buttonControl.GetComponent<ButtonController>();
        accessManager = GameObject.Find("AccessibilityManager");
        notesScript = GetComponent<ScrollNotes>();

        
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
        if (audioOnlyMode)
        {
            visualblock.SetActive(true);
        }
        if (visualOnlyMode)
        {
            buttonscript.notehit = null;
            buttonscript.goclip = null;
            buttonscript.patternhit = null;
            notesScript.musicclips[0] = null;
        }
    }


    public void updateScore()
    {
        scoretxt.text = "Score: "+score;
    }
}
