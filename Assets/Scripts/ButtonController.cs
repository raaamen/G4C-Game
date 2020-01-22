using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public int score;

    public bool press;
    public bool buttonPressed;
    public bool playsound;

    public KeyCode key;

    public AudioSource audiosrc;
    public AudioClip notehit;
    public AudioClip patternhit;

    public GameManager gameManager;
    

    // Start is called before the first frame update
    private void Awake()
    {
        audiosrc = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    /**private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            press = true;
            Debug.Log("can press button");

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("button clicked");
            audio.Play();
            gameManager.score += 5;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            Debug.Log("can't press button");
            press = false;
        }
    }
    */   

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Note")
        {
            Debug.Log("can press note");
            if (Input.GetKeyDown(key))
            {
                Debug.Log("key pressed");
                Destroy(collision.gameObject);
                audiosrc.clip = notehit;
                audiosrc.Play();
                gameManager.score += 5;
            }
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pattern Note")
        {
            Debug.Log("Pattern note detected");
            audiosrc.clip = patternhit;
            audiosrc.Play();
        }
    }


}
