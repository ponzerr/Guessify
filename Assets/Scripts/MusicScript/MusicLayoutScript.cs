using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicLayoutScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelmsc = PlayerPrefs.GetInt("levelmsc", 1);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelmsc)
                lvlButtons[i].interactable = false;
        }
    }


}