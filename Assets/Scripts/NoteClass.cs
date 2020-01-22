using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteClass : MonoBehaviour
{

    Vector3 pos;

    public NoteClass(Vector3 v)
    {
        pos = v;
    }

    public Vector3 getPos()
    {
        return pos;
    }

}
