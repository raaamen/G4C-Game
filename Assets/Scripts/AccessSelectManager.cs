using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessSelectManager : MonoBehaviour
{

    public bool menuOpen;

    public GameObject titleText;
    public GameObject othertext;

    private int _MenuIndex;
    public int MenuIndex
    {
        get
        {
            return _MenuIndex;
        }
        set
        {
            foreach (var item in startArrows)
            {
                item.SetActive(false);
            }
            if (value > 1)
            {
                _MenuIndex = 0;
            }
            else if (value < 0)
            {
                _MenuIndex = 1;
            }
            else _MenuIndex = value;
            startArrows[_MenuIndex].SetActive(true);
        }
    }

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
            if (value > 2)
            {
                _AccessIndex = 0;
            }
            else if (value < 0)
            {
                _AccessIndex = 2;
            }
            else _AccessIndex = value;
            accessArrows[_AccessIndex].SetActive(true);
        }
    }

    public GameObject[] startButtons;
    public GameObject[] accessButtons;
    public GameObject[] accessArrows;
    public GameObject[] startArrows;

    public GameObject selectedMenuButton;
    public GameObject selectedAccessOption;
    public GameObject exitButton;

    // Start is called before the first frame update
    private void Awake()
    {
        AccessIndex = 2;
        MenuIndex = 1;
        selectedMenuButton = startButtons[MenuIndex];
        selectedAccessOption = accessButtons[AccessIndex];
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (menuOpen == false)
        {
            titleText.SetActive(true);
            othertext.SetActive(true);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                MenuIndex++;
                selectedMenuButton = startButtons[MenuIndex];
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MenuIndex--;
                selectedMenuButton = startButtons[MenuIndex];
            }
            else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                selectedMenuButton.GetComponent<Button>().onClick.Invoke();
                menuOpen = true;
            }
        }
        else if (menuOpen)
        {
            titleText.SetActive(false);
            othertext.SetActive(false);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                AccessIndex++;
                selectedAccessOption = accessButtons[AccessIndex];
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                AccessIndex--;
                selectedAccessOption = accessButtons[AccessIndex];
            }
            else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                if (selectedAccessOption.GetComponent<Slider>().value==1)
                {
                    selectedAccessOption.GetComponent<Slider>().value = 0;
                }
                else if (selectedAccessOption.GetComponent<Slider>().value == 0)
                {
                    selectedAccessOption.GetComponent<Slider>().value = 1;
                }
            }
            else if (Input.GetKeyDown(KeyCode.Backspace)||Input.GetKeyDown(KeyCode.Escape))
            {
                exitButton.GetComponent<Button>().onClick.Invoke();
                menuOpen = false;
            }
        }
    }
}
