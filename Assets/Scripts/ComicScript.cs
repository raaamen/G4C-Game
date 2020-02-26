using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComicScript : MonoBehaviour
{

    Image imageComp;
    public bool comicSequenceOn;

    public Image[] comicImages;
    public int index;
    public GameObject imageHolder;

    // Start is called before the first frame update
    private void Awake()
    {
        imageComp = GetComponent<Image>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (comicSequenceOn)
        {
            imageHolder.SetActive(true);   
            if (Input.anyKeyDown)
            {
                
            }
        }
    }

    private void OnEnable()
    {
        comicSequenceOn = true;
    }
    private void OnDisable()
    {
        comicSequenceOn = false;
    }
}
