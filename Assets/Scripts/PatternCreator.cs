using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternCreator : MonoBehaviour
{

    public NoteClass[] noteslvl1;
    public NoteClass[] noteslvl2;
    public NoteClass[] noteslvl3;

    public GameObject noteObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadNotes()
    {
        foreach (var item in noteslvl1)
        {
            Instantiate(noteObj, item.getPos(), Quaternion.identity);
        }
    }

}
