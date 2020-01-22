using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComicScript : MonoBehaviour
{

    Image imageComp;
    public bool comicSequenceOn;

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
