using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodLayoutScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] lvlButtons;
	
    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelDi", 1);
        for(int i=0; i < lvlButtons.Length; i++){
            if(i + 1 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }
	
	
}