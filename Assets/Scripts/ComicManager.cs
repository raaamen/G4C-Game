using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComicManager : MonoBehaviour
{
    public Image comicPanel;
    public Sprite[] comicHolder;
    public int i = 0;
    public bool comicDone;
    public GameObject continueButton;
    public int temp;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && i < comicHolder.Length)
        {
            comicPanel.sprite = comicHolder[i];
            i++;
            if (i==comicHolder.Length-1)
            {
                continueButton.SetActive(true);
            }

        }
    }
}
