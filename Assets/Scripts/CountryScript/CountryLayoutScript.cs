using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountryLayoutScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelcty = PlayerPrefs.GetInt("levelcty", 1);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelcty)
                lvlButtons[i].interactable = false;
        }
    }


}