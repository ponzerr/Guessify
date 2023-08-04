using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public CoinSystem coins;
    public Button[] lvlButtons;
    public Button[] unlockButton1;
    public Button[] unlockButton2;
	public Button[] unlockButton3;
	public Button[] unlockButton4;
	public Button[] unlockButton5;
    public Button[] unlockButton6;
    public Button[] unlockButton7;
    public Button[] unlockButton8;
    public GameObject NotificationPanel;
    public GameObject NotificationPanel2;
	public GameObject NotificationPanel3;
	public GameObject NotificationPanel4;
	public GameObject NotificationPanel5;
    public GameObject NotificationPanel6;
    public GameObject NotificationPanel7;
    public GameObject NotificationPanel8;
    public int lockbutton = 1;
    public int level = 1;
    public AudioSource error;
    public AudioSource unlock;
    // Start is called before the first frame update
    void Start()
    {

       level = PlayerPrefs.GetInt("levelAt");
        PlayerPrefs.SetInt("levelAt", level);
        //int unlock = PlayerPrefs.GetInt("unlock", 0);

        for (int i=0; i < lvlButtons.Length; i++){
            if(i + 1 > level){
                lvlButtons[i].interactable = false;
            }else{
                lvlButtons[i].interactable = true;
            }
        }

        lockbutton = PlayerPrefs.GetInt("Lock", 1);
        for(int i=0; i < unlockButton1.Length; i++){
            if(i + 2 > lockbutton){
                unlockButton1[i].interactable = true;
            }else{
                unlockButton1[i].interactable = false;
            }
        }
	
        for(int i=0; i < unlockButton2.Length; i++){
            if(i + 3 > lockbutton){
                unlockButton2[i].interactable = true;
            }else{
                unlockButton2[i].interactable = false;
            }
        }
		
		for(int i=0; i < unlockButton3.Length; i++){
            if(i + 4 > lockbutton){
                unlockButton3[i].interactable = true;
            }else{
                unlockButton3[i].interactable = false;
            }
        }
		
		for(int i=0; i < unlockButton4.Length; i++){
            if(i + 5 > lockbutton){
                unlockButton4[i].interactable = true;
            }else{
                unlockButton4[i].interactable = false;
            }
        }
		
		for(int i=0; i < unlockButton5.Length; i++){
            if(i + 6 > lockbutton){
                unlockButton5[i].interactable = true;
            }else{
                unlockButton5[i].interactable = false;
            }
        }

        for (int i = 0; i < unlockButton6.Length; i++)
        {
            if (i + 7 > lockbutton)
            {
                unlockButton6[i].interactable = true;
            }
            else
            {
                unlockButton6[i].interactable = false;
            }
        }

        for (int i = 0; i < unlockButton7.Length; i++)
        {
            if (i + 8 > lockbutton)
            {
                unlockButton7[i].interactable = true;
            }
            else
            {
                unlockButton7[i].interactable = false;
            }
        }

        for (int i = 0; i < unlockButton8.Length; i++)
        {
            if (i + 9 > lockbutton)
            {
                unlockButton8[i].interactable = true;
            }
            else
            {
                unlockButton8[i].interactable = false;
            }
        }
        //if(unlock == 1){
        //unlockButton[0].interactable = false;
        // }else{
        //unlockButton[0].interactable = true;
        //}

    }

    void Update() {
        level = PlayerPrefs.GetInt("levelAt");
    }

    public void Level2Update(){
        if(PlayerPrefs.GetInt("Coins") >= 500 )
        {
            lvlButtons[1].interactable = true;
            unlock.Play();
            coins.CoinMin();
            BaseLevelUp();
        }else{
            NotificationPanel.SetActive(true);
            //error = GetComponent<AudioSource>();
            error.Play();
            //PlayerPrefs.SetInt("unlock", 0);
			unlockButton1[0].interactable = true;
        }
    }

    public void Level3Update(){

        if(PlayerPrefs.GetInt("Coins") >= 500){
            lvlButtons[2].interactable = true;
            unlock.Play();
            coins.CoinMin();
            lockbutton = lockbutton + 1;
            BaseLevelUp();
        }else{
            NotificationPanel2.SetActive(true);
            //error = GetComponent<AudioSource>();
            error.Play();
            //PlayerPrefs.SetInt("unlock", 0);
            unlockButton2[0].interactable = true;
        }
    }

    public void Level4Update()
    {

        if (PlayerPrefs.GetInt("Coins") >= 500)
        {
            lvlButtons[3].interactable = true;
            unlock.Play();
            coins.CoinMin();
            lockbutton = lockbutton + 2;
            BaseLevelUp();
        }
        else
        {
            NotificationPanel3.SetActive(true);
            //error = GetComponent<AudioSource>();
            error.Play();
            //PlayerPrefs.SetInt("unlock", 0);
            unlockButton3[0].interactable = true;
        }
    }

    public void Level5Update(){

        if(PlayerPrefs.GetInt("Coins") >= 500){
            lvlButtons[4].interactable = true;
            unlock.Play();
            coins.CoinMin();
            lockbutton = lockbutton + 3;
            BaseLevelUp();
        }else{
            NotificationPanel4.SetActive(true);
            //error = GetComponent<AudioSource>();
            error.Play();
            //PlayerPrefs.SetInt("unlock", 0);
            unlockButton4[0].interactable = true;
        }
    }
	
		public void Level6Update(){

        if(PlayerPrefs.GetInt("Coins") >= 500){
            lvlButtons[5].interactable = true;
            unlock.Play();
            coins.CoinMin();
            lockbutton = lockbutton + 4;
            BaseLevelUp();
        }else{
            NotificationPanel5.SetActive(true);
            //error = GetComponent<AudioSource>();
            error.Play();
            //PlayerPrefs.SetInt("unlock", 0);
            unlockButton5[0].interactable = true;
        }
    }

    public void Level7Update()
    {

        if (PlayerPrefs.GetInt("Coins") >= 500)
        {
            lvlButtons[6].interactable = true;
            unlock.Play();
            coins.CoinMin();
            lockbutton = lockbutton + 5;
            BaseLevelUp();
        }
        else
        {
            NotificationPanel6.SetActive(true);
            //error = GetComponent<AudioSource>();
            error.Play();
            //PlayerPrefs.SetInt("unlock", 0);
            unlockButton6[0].interactable = true;
        }
    }

    public void Level8Update()
    {

        if (PlayerPrefs.GetInt("Coins") >= 500)
        {
            lvlButtons[7].interactable = true;
            unlock.Play();
            coins.CoinMin();
            lockbutton = lockbutton + 6;
            BaseLevelUp();
        }
        else
        {
            NotificationPanel7.SetActive(true);
            //error = GetComponent<AudioSource>();
            error.Play();
            //PlayerPrefs.SetInt("unlock", 0);
            unlockButton7[0].interactable = true;
        }
    }

    public void Level9Update()
    {

        if (PlayerPrefs.GetInt("Coins") >= 500)
        {
            lvlButtons[8].interactable = true;
            unlock.Play();
            coins.CoinMin();
            lockbutton = lockbutton + 7;
            BaseLevelUp();
        }
        else
        {
            NotificationPanel8.SetActive(true);
            //error = GetComponent<AudioSource>();
            error.Play();
            //PlayerPrefs.SetInt("unlock", 0);
            unlockButton8[0].interactable = true;
        }
    }



    public void BaseLevelUp(){
        level = level + 1;
        lockbutton = lockbutton + 1;
        PlayerPrefs.SetInt("levelAt", level);
        PlayerPrefs.SetInt("Lock", lockbutton);
   }
}
