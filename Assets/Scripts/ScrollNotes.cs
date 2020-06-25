using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScrollNotes : MonoBehaviour
{

    public float beatTempo;

    public bool hasStarted;

    public AudioSource music;

    public AudioClip[] musicclips;

    public GameObject GameManager;

    public IEnumerator coroutine;

    public GameObject countdowntext;
    public GameObject countdownnumtext;

    public bool canStart = false;


    // Start is called before the first frame update
    private void Awake()
    {
        coroutine = countdowntostart();
        beatTempo = 110;
        beatTempo = beatTempo / 60f;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for moving the notes


        if (!hasStarted)
        {
            if (canStart)
            {
                Debug.Log("attempting to start");
                StartCoroutine(coroutine);
                Debug.Log(hasStarted);
                canStart = false;
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

    public IEnumerator countdowntostart()
    {
        Debug.Log("Counting down 3 seconds");
        countdowntext.SetActive(true);
        countdownnumtext.SetActive(true);
        countdownnumtext.GetComponent<TextMeshProUGUI>().text = "3";
        yield return new WaitForSeconds(1);
        countdownnumtext.GetComponent<TextMeshProUGUI>().text = "2";
        yield return new WaitForSeconds(1);
        countdownnumtext.GetComponent<TextMeshProUGUI>().text = "1";
        yield return new WaitForSeconds(1);
        countdownnumtext.GetComponent<TextMeshProUGUI>().text = "Start!";
        countdownnumtext.SetActive(false);
        countdowntext.SetActive(false);
        hasStarted = true;
        
    }

}
