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
    public ScrollNotes notesScript;

    // Start is called before the first frame update

    private void Awake()
    {

        accessManager = GameObject.Find("AccessibilityManager");
        levelManager = GameObject.Find("LevelSelectedManager");
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
        subtitlesOn = accessManager.GetComponent<AccessManager>().subtitlesOn;
    }

    public void checkLvlLoad()
    {
        switch (levelManager.GetComponent<LevelSelectManage>().levelSelected)
        {
            case 1:
                loadLevel1();
                break;
            case 2:
                loadLevel2();
                break;
            case 3:
                loadLevel3();
                break;
        }
    }

    public void updateScore()
    {
        scoretxt.text = "Score: "+score;
    }

    public void loadLevel1()
    {
        foreach (var item in notesScript.noteslvl1)
        {
            Vector3 spawnPos = item.GetComponent<NoteProperty>().getPos();
            Instantiate(item, spawnPos, Quaternion.identity);
        }
    }
    public void loadLevel2()
    {
        foreach (var item in notesScript.noteslvl2)
        {
            Vector3 spawnPos = item.GetComponent<NoteProperty>().getPos();
            Instantiate(item, spawnPos, Quaternion.identity);
        }
    }
    public void loadLevel3()
    {
        foreach (var item in notesScript.noteslvl3)
        {
            Vector3 spawnPos = item.GetComponent<NoteProperty>().getPos();
            Instantiate(item, spawnPos, Quaternion.identity);
        }
    }

}
