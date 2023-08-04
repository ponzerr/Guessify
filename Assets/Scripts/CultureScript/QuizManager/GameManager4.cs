using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager4 : MonoBehaviour
{
    public string nextLevel = "Level 02";
    public int levelToReach = 2;

    // Start is called before the first frame update
    public void WinLevel()
    {
        if (PlayerPrefs.GetInt("levelcult") < levelToReach)
        {
            PlayerPrefs.SetInt("levelcult", levelToReach);
        }
    }
}