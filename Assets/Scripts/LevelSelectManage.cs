using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectManage : MonoBehaviour
{

    public int levelSelected;

    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
