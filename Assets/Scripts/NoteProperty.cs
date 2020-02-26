using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteProperty : MonoBehaviour
{

    Vector3 notePos;
    public string type;

    // Start is called before the first frame update
    private void Awake()
    {
        /*switch (gameObject.tag)
        {
            default:
                break;
        }
        */
    }

    public Vector3 getPos()
    {
        return notePos;
    }
    public void setPos()
    {

    }
}
