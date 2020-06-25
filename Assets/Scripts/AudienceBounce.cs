using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceBounce : MonoBehaviour
{
    public float timer;
    public float offset;

    public bool running;

    public int random;
    
    // Start is called before the first frame update
    void Start()
    {

        running = false;
        random = Random.Range(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (running == false)
        {
            counter();
        }
        
    }

    public void bounceDown()
    {
        transform.position -= new Vector3(0, offset);
    }
    public void bounceUp()
    {
        transform.position += new Vector3(0, offset);
    }

    public IEnumerator counter()
    {
        running = true;
        bounceDown();
        yield return new WaitForSeconds(1f);
        bounceUp();
        yield return new WaitForSeconds(1f);
        running = false;
    }



}
