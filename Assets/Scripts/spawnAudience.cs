using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnAudience : MonoBehaviour
{

    public int audienceNum;
    public GameObject audienceobj;

    public int posx;
    public int posy;
    public int offset;

    public Canvas can;

    public int[] colors;

    // Start is called before the first frame update
    void Start()
    {
        audienceNum = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
