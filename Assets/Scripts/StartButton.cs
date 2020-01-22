using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void onClick()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("gameScene");

        //fade to black and fade into new scene
        //basically fade out here and new scene manages fade in
    }
}
