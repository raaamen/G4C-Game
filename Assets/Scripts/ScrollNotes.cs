using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollNotes : MonoBehaviour
{

    public float beatTempo;
    public float startTimer;

    public bool hasStarted;
    public bool timerCount;

    public AudioSource music;

    public AudioClip[] musicclips;

    public NoteClass[] noteslvl1;
    public NoteClass[] noteslvl2;
    public NoteClass[] noteslvl3;

    public GameObject noteObj;

    public IEnumerator coroutine;


    // Start is called before the first frame update
    private void Awake()
    {
        coroutine = countdowntostart(3);
    }
    void Start()
    {
        beatTempo = beatTempo / 60f;
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
            spawnNotes();
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
        
    }

    void spawnNotes()
    {
        foreach (var item in noteslvl1)
        {
            Instantiate(noteObj, item.getPos(), Quaternion.identity);
        }
    }

    public IEnumerator countdowntostart(int seconds)
    {
        Debug.Log("Counting down 3 seconds");
        yield return new WaitForSeconds(seconds);
        hasStarted = true;
    }

}
