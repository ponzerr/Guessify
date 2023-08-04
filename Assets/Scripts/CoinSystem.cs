using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public Text coinDisplayText;
	public Text coinDisplayText2;
	

    public int currentCoin = 0;
	

    void Start() {
        currentCoin = 0;

        if(PlayerPrefs.HasKey("Coins")){
            currentCoin = PlayerPrefs.GetInt("Coins");
            PlayerPrefs.SetInt("Coins", currentCoin);
        }
        coinDisplayText.text = "" + currentCoin;
    }

    public void CoinUpdate(){
		int winCoins = 50;
        currentCoin = currentCoin + winCoins;
        coinDisplayText.text = "" + currentCoin;
		coinDisplayText2.text = "+  " + winCoins;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinUpdate2(){
		int winCoins2 = 30;
        currentCoin = currentCoin + winCoins2;
        coinDisplayText.text = "" + currentCoin;
		coinDisplayText2.text = "+  " + winCoins2;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinUpdate3(){
		int winCoins3 = 20;
        currentCoin = currentCoin + winCoins3;
        coinDisplayText.text = "" + currentCoin;
		coinDisplayText2.text = "+  " + winCoins3;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }

    void Update() {
        currentCoin = PlayerPrefs.GetInt("Coins"); 
    }

    public void CoinMin(){
        currentCoin = currentCoin - 500;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }

    public void HintBuy(){
        currentCoin = currentCoin - 100;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);	
    }
	
	public void HintBuy2(){
        currentCoin = currentCoin - 200;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);	
    }
	
	public void HintBuy3(){
        currentCoin = currentCoin - 150;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);	
    }
	
	public void HintBuy4(){
        currentCoin = currentCoin - 250;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);	
    }
	
	public void HintBuy5(){
        currentCoin = currentCoin - 200;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);	
    }
	
	public void HintBuy6(){
        currentCoin = currentCoin - 300;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);	
    }
	
	public void HintBuy7(){
        currentCoin = currentCoin - 3;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);	
    }
	public void HintBuy8(){
        currentCoin = currentCoin - 5;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);	
    }
	
    public void CoinReset(){
        currentCoin = 0;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinReward(){
        currentCoin = 5;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinReward2(){
        currentCoin = 10;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinReward3(){
        currentCoin = 20;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinReward4(){
        currentCoin = 30;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinReward5(){
        currentCoin = 40;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinReward6(){
        currentCoin = 50;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void CoinReward7(){
        currentCoin = 100;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	//TASKREWARDS
	
	public void TaskCoins(){
		int winCoins4 = 100;
        currentCoin = currentCoin + winCoins4;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }

    public void DailyCoins()
    {
        int winCoins5 = 300;
        currentCoin = currentCoin + winCoins5;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }

    public void CoinCheat(){
        currentCoin = 5000;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
	
	public void LooseCoins(){
        currentCoin = currentCoin - 50;
        coinDisplayText.text = "" + currentCoin;
        PlayerPrefs.SetInt("Coins", currentCoin);
    }
    // Start is called before the first frame update
	
	
	
}
