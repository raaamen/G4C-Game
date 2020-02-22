using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectManage : MonoBehaviour
{

    public int levelSelected;
    public GameObject[] levelButtons;
    public GameObject selectedButton;
    public GameObject[] levelArrows;

    public int index;
    [SerializeField]
    public int Index
    {
        get
        {
            return index;
        }
        set
        {
            foreach (var item in levelArrows)
            {
                item.SetActive(false);
            }
            if (value > 2)
            {
                index = 0;
            }
            else if (value < 0)
            {
                index = 2;
            }
            else index = value;
            levelArrows[index].SetActive(true);
        }
    }

    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        Index = 0;
        selectedButton = levelButtons[Index];
        levelArrows[index].SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Index++;
            selectedButton = levelButtons[Index];
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Index--;
            selectedButton = levelButtons[Index];
        }
        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            selectedButton.GetComponent<Button>().onClick.Invoke();
        }

    }


}
