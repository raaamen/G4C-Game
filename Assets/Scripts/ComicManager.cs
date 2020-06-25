using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComicManager : MonoBehaviour
{
    public Image comicPanel;
    public List<Sprite> comicHolder;
    public int i
    {
        
        get
        {
            return i;
        }
        set
        {
            if (i == comicHolder.Count)
            {
                continueButton.SetActive(true);
                comicDone = true;
            }
            else comicPanel.sprite = comicHolder[i];
        }
    }
    public bool comicDone;
    public GameObject continueButton;
    public int temp;

    private void Awake()
    {
        comicHolder = new List<Sprite>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && i < comicHolder.Count)
        {
            i++;

        }
    }
}
