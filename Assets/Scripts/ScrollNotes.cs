using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollNotes : MonoBehaviour
{

    public float beatTempo;
    //level 1 is 110bpm
    //level 2 165bpm
    //level 3 140bpm
    public float startTimer;

    public bool hasStarted;
    public bool timerCount;

    public AudioSource music;

    public AudioClip[] musicclips;

    public GameObject[] noteslvl1;
    public GameObject[] noteslvl2;
    public GameObject[] noteslvl3;

    public GameObject noteObj;
    public GameObject goNoteObj;
    public GameObject patternNoteObj;
    public GameObject GameManager;

    public IEnumerator coroutine;


    // Start is called before the first frame update
    private void Awake()
    {
        coroutine = countdowntostart(3);
        beatTempo = 110;
        beatTempo = beatTempo / 60f;
    }
    void Start()
    {
        /*switch (levelSelect)
        {
            case 1:
                beatTempo = 110;
                music.clip = musicclips[0];
                break;
            case 2:
                beatTempo = 165;
                music.clip = musicclips[1];
                break;
            case 3:
                beatTempo = 140;
                music.clip = musicclips[2];
                break;
        }
        beatTempo = beatTempo / 60f;
        **/
    }

    // Update is called once per frame
    void Update()
    {
        //for moving the notes


        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                Debug.Log("attempting to start");
                StartCoroutine(coroutine);
                Debug.Log(hasStarted);
            }
        }
        else
        {
            music.clip = musicclips[0];
            if (!music.isPlaying)
            {
                music.Play();
            }
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
        
    }

    public IEnumerator countdowntostart(int seconds)
    {
        Debug.Log("Counting down 3 seconds");
        yield return new WaitForSeconds(seconds);
        hasStarted = true;
    }

}
