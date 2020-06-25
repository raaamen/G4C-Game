using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public AudioClip goclip;

    public GameManager gameManager;

    public GameObject particle1;
    public GameObject particle2;
    

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
  

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Note")
        {
            Debug.Log("can press note");
            if (Input.GetKeyDown(key))
            {
                Debug.Log("key pressed");
                ParticleSystem.MainModule main = particle1.GetComponent<ParticleSystem>().main;
                main.startColor = Color.blue;
                ParticleSystem.MainModule main2 = particle2.GetComponent<ParticleSystem>().main;
                main2.startColor = Color.blue;
                particle1.GetComponent<ParticleSystem>().Play();
                particle2.GetComponent<ParticleSystem>().Play();
                Destroy(collision.gameObject);
                audiosrc.clip = notehit;
                audiosrc.Play();
                gameManager.score += 5;
                gameManager.updateScore();
            }
        }



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pattern Note")
        {
            Debug.Log("Pattern note detected");
            ParticleSystem.MainModule main = particle1.GetComponent<ParticleSystem>().main;
            main.startColor = Color.white;
            ParticleSystem.MainModule main2 = particle2.GetComponent<ParticleSystem>().main;
            main2.startColor = Color.white;
            particle1.GetComponent<ParticleSystem>().Play();
            particle2.GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject);
            audiosrc.clip = patternhit;
            audiosrc.Play();
        }
        if (collision.gameObject.tag == "Go Note")
        {
            Debug.Log("begin");
            ParticleSystem.MainModule main = particle1.GetComponent<ParticleSystem>().main;
            main.startColor = Color.green;
            ParticleSystem.MainModule main2 = particle2.GetComponent<ParticleSystem>().main;
            main2.startColor = Color.green;
            particle1.GetComponent<ParticleSystem>().Play();
            particle2.GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject);
            audiosrc.clip = goclip;
            audiosrc.Play();
        }
        if (collision.gameObject.tag =="End Signal")
        {
            
            SceneManager.LoadScene("endLevelScene");
        }
    }


}
