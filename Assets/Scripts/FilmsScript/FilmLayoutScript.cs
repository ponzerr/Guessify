using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilmLayoutScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelflm = PlayerPrefs.GetInt("levelflm", 1);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelflm)
                lvlButtons[i].interactable = false;
        }
    }


}