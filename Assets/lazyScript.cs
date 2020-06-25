using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lazyScript : MonoBehaviour
{

    public GameObject[] accessButtons;
    public GameObject[] accessArrows;
    public GameObject selectedMenuButton;

    private int _AccessIndex;
    public int AccessIndex
    {
        get
        {
            return _AccessIndex;
        }
        set
        {
            foreach (var item in accessArrows)
            {
                item.SetActive(false);
            }
            if (value > 1)
            {
                _AccessIndex = 0;
            }
            else if (value < 0)
            {
                _AccessIndex = 1;
            }
            else _AccessIndex = value;
            accessArrows[_AccessIndex].SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        AccessIndex = 0;
        selectedMenuButton = accessButtons[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AccessIndex++;
            selectedMenuButton = accessButtons[AccessIndex];
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AccessIndex--;
            selectedMenuButton = accessButtons[AccessIndex];
        }
        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            selectedMenuButton.GetComponent<Button>().onClick.Invoke();
        }
    }
}
