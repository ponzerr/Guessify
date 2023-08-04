using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationLayoutScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelloc = PlayerPrefs.GetInt("levelloc", 1);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelloc)
                lvlButtons[i].interactable = false;
        }
    }


}