using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteClass : MonoBehaviour
{

    public Vector3 pos;
    public string type;
    public GameObject notetype;

    public NoteClass(Vector3 v)
    {
        pos = v;
    }

    public Vector3 getPos()
    {
        return pos;
    }
    public string getType()
    {
        return type;
    }

}
