using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TechnoLayoutScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        int leveltco = PlayerPrefs.GetInt("leveltco", 1);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > leveltco)
                lvlButtons[i].interactable = false;
        }
    }


}