using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintManager : MonoBehaviour
{
	public CoinSystem coins;
	public Button HintPanel1;
	public Button HintPanel2;
	public GameObject HintText;
	public GameObject HintText2;
	public GameObject NotificationPanel;
	public GameObject NotificationPanel2;
	public AudioSource error;
    public AudioSource unlock;
	
	public void HintUpdate1(){
        if(PlayerPrefs.GetInt("Coins") >= 100){
			HintPanel1.interactable = true;
			HintText.SetActive(true);
			coins.HintBuy();
			unlock.Play();
		}else{
			NotificationPanel.SetActive(true);
            error.Play();
		}
    }

    public void HintUpdate1_2()
    {
        if (PlayerPrefs.GetInt("Coins") >= 100)
        {
            HintPanel1.interactable = true;
            HintText.SetActive(true);
            coins.HintBuy();
            unlock.Play();
        }
        else
        {
            NotificationPanel.SetActive(true);
            error.Play();
        }
    }

    public void HintUpdate1_3()
    {
        if (PlayerPrefs.GetInt("Coins") >= 100)
        {
            HintPanel1.interactable = true;
            HintText.SetActive(true);
            coins.HintBuy();
            unlock.Play();
        }
        else
        {
            NotificationPanel.SetActive(true);
            error.Play();
        }
    }

    public void HintUpdate2(){
        if(PlayerPrefs.GetInt("Coins") >= 200){
			HintPanel2.interactable = true;
			HintText2.SetActive(true);
			coins.HintBuy2();
			unlock.Play();
		}else{
			NotificationPanel2.SetActive(true);
            error.Play();
		}
	}

    public void HintUpdate2_2()
    {
        if (PlayerPrefs.GetInt("Coins") >= 250)
        {
            HintPanel2.interactable = true;
            HintText2.SetActive(true);
            coins.HintBuy2();
            unlock.Play();
        }
        else
        {
            NotificationPanel2.SetActive(true);
            error.Play();
        }
    }

    public void HintUpdate2_3()
    {
        if (PlayerPrefs.GetInt("Coins") >= 300)
        {
            HintPanel2.interactable = true;
            HintText2.SetActive(true);
            coins.HintBuy2();
            unlock.Play();
        }
        else
        {
            NotificationPanel2.SetActive(true);
            error.Play();
        }
    }



}