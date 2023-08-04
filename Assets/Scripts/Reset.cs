using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public int BaseLevel = 1;
    public int MaxLevel = 5;
    public int BaseCoin = 0;
    public int BaseUnlock = 0;
    public int MaxUnlock = 1;
    public Button[] unlockButton1;
    public Button[] unlockButton2;
	public Button[] unlockButton3;
	public Button[] unlockButton4;
	public Button[] unlockButton5;
    public Button[] unlockButton6;
    public Button[] unlockButton7;
    public Button[] unlockButton8;
    public CoinSystem coins;

    public Button[] lvlButtons;

    // Start is called before the first frame update
    public void ResetGame(){
        PlayerPrefs.GetInt("levelDi");
        PlayerPrefs.SetInt("levelDi", BaseLevel);
        PlayerPrefs.GetInt("levelloc");
        PlayerPrefs.SetInt("levelloc", BaseLevel);
        PlayerPrefs.GetInt("levelanml");
        PlayerPrefs.SetInt("levelanml", BaseLevel);
        PlayerPrefs.GetInt("levelcult");
        PlayerPrefs.SetInt("levelcult", BaseLevel);
        PlayerPrefs.GetInt("levelflm");
        PlayerPrefs.SetInt("levelflm", BaseLevel);
        PlayerPrefs.GetInt("levelmsc");
        PlayerPrefs.SetInt("levelmsc", BaseLevel);
        PlayerPrefs.GetInt("leveljob");
        PlayerPrefs.SetInt("leveljob", BaseLevel);
        PlayerPrefs.GetInt("levelcty");
        PlayerPrefs.SetInt("levelcty", BaseLevel);
        PlayerPrefs.GetInt("levelAt");
        PlayerPrefs.SetInt("levelAt", BaseLevel);
        PlayerPrefs.GetInt("Lock");
        PlayerPrefs.SetInt("Lock", BaseLevel);

        
        //int unlock = PlayerPrefs.GetInt("unlock");
        //PlayerPrefs.SetInt("unlock", BaseUnlock);
        unlockButton1[0].interactable = true;
        unlockButton2[0].interactable = true;
		unlockButton3[0].interactable = true;
		unlockButton4[0].interactable = true;
        unlockButton5[0].interactable = true;
        lvlButtons[1].interactable = false;
        lvlButtons[2].interactable = false;
		lvlButtons[3].interactable = false;
		lvlButtons[4].interactable = false;
    }

    public void CheatGame(){
        PlayerPrefs.GetInt("levelDi");
        PlayerPrefs.SetInt("levelDi", MaxLevel);
        PlayerPrefs.GetInt("levelanmls");
        PlayerPrefs.SetInt("levelanmls", MaxLevel);
        PlayerPrefs.GetInt("levelSekarang");
        PlayerPrefs.SetInt("levelSekarang", MaxLevel);
        
        //int unlock = PlayerPrefs.GetInt("unlock");
        //PlayerPrefs.SetInt("unlock", MaxUnlock);
        unlockButton1[0].interactable = false;
        unlockButton2[0].interactable = false;
		unlockButton3[0].interactable = false;
		unlockButton4[0].interactable = false;
		unlockButton5[0].interactable = false;
        lvlButtons[1].interactable = true;
        lvlButtons[2].interactable = true;
		lvlButtons[3].interactable = true;
		lvlButtons[4].interactable = true;
		lvlButtons[5].interactable = true;
		lvlButtons[6].interactable = true;
    }
}
