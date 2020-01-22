using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessManager : MonoBehaviour
{

    public bool audioOnlyMode;
    public bool visualOnlyMode;
    public bool subtitlesOn;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
