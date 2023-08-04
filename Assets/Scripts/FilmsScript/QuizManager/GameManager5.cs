using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager5 : MonoBehaviour
{
    public string nextLevel = "Level 02";
    public int levelToReach = 2;

    // Start is called before the first frame update
    public void WinLevel()
    {
        if (PlayerPrefs.GetInt("levelflm") < levelToReach)
        {
            PlayerPrefs.SetInt("levelflm", levelToReach);
        }
    }
}