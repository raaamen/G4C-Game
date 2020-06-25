using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class lightScript : MonoBehaviour
{
    public Light2D lightcomponent;
    public bool coroutinerunning;
    public GameObject lightObj;
    public float waittime;
    public float total;
    // Start is called before the first frame update
    void Start()
    {
        lightcomponent = GetComponentInChildren<Light2D>();
        waittime = 1f;
        total = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!coroutinerunning)
        {
            StartCoroutine("lightchange");   
        }
    }
    IEnumerator lightchange()
    {
        coroutinerunning = true;
        float elapsed = 0.0f;
        while (elapsed<total)
        {
            elapsed += Time.deltaTime;
            lightcomponent.color = Color.Lerp(Color.magenta, Color.red, (elapsed / total));
            yield return null;
        }
        elapsed = 0.0f;
        while (elapsed < total)
        {
            elapsed += Time.deltaTime;
            lightcomponent.color = Color.Lerp(Color.red, Color.green, (elapsed / total));
            yield return null;
        }
        elapsed = 0.0f;
        while (elapsed < total)
        {
            elapsed += Time.deltaTime;
            lightcomponent.color = Color.Lerp(Color.green, Color.yellow, (elapsed / total));
            yield return null;
        }
        elapsed = 0.0f;
        while (elapsed < total)
        {
            elapsed += Time.deltaTime;
            lightcomponent.color = Color.Lerp(Color.yellow, Color.cyan, (elapsed / total));
            yield return null;
        }
        elapsed = 0.0f;
        while (elapsed < total)
        {
            elapsed += Time.deltaTime;
            lightcomponent.color = Color.Lerp(Color.cyan, Color.blue, (elapsed / total));
            yield return null;
        }
        elapsed = 0.0f;
        while (elapsed < total)
        {
            elapsed += Time.deltaTime;
            lightcomponent.color = Color.Lerp(Color.blue, Color.magenta, (elapsed / total));
            yield return null;
        }
        coroutinerunning = false;
    }
}
