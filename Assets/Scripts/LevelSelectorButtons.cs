using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorButtons : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void level1Clicked()
    {
        GameObject.Find("LevelSelectedManager").GetComponent<LevelSelectManage>().levelSelected = 1;
        SceneManager.LoadScene("gameScene");
    }
    public void level2Clicked()
    {
        GameObject.Find("LevelSelectedManager").GetComponent<LevelSelectManage>().levelSelected = 2;
        SceneManager.LoadScene("gameScene");
    }
    public void level3Clicked()
    {
        GameObject.Find("LevelSelectedManager").GetComponent<LevelSelectManage>().levelSelected = 3;
        SceneManager.LoadScene("gameScene");
    }
}
