using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyReward : MonoBehaviour
{
    public CoinSystem coins;
    public int LastDate;

    public int Day_1;
    public int Day_2;
    public int Day_3;
    public int Day_4;
    public int Day_5;
    public int Day_6;
    public int Day_7;


    public GameObject OFF_1;
    public GameObject ACTIVE_1;
    public GameObject CHECK_1;

    public GameObject OFF_2;
    public GameObject ACTIVE_2;
    public GameObject CHECK_2;

    public GameObject OFF_3;
    public GameObject ACTIVE_3;
    public GameObject CHECK_3;

    public GameObject OFF_4;
    public GameObject ACTIVE_4;
    public GameObject CHECK_4;

    public GameObject OFF_5;
    public GameObject ACTIVE_5;
    public GameObject CHECK_5;

    public GameObject OFF_6;
    public GameObject ACTIVE_6;
    public GameObject CHECK_6;

    public GameObject OFF_7;
    public GameObject ACTIVE_7;
    public GameObject CHECK_7;



    void Start()
    {
        Day_1 = PlayerPrefs.GetInt("Day_1");
        Day_2 = PlayerPrefs.GetInt("Day_2");
        Day_3 = PlayerPrefs.GetInt("Day_3");
        Day_4 = PlayerPrefs.GetInt("Day_4");
        Day_5 = PlayerPrefs.GetInt("Day_5");
        Day_6 = PlayerPrefs.GetInt("Day_6");
        Day_7 = PlayerPrefs.GetInt("Day_7");

        LastDate = PlayerPrefs.GetInt("LastDate");

        Reward();

        if (LastDate != System.DateTime.Now.Day)
        {
            if (Day_1 == 0)
            {
                Day_1 = 1;
            }
            else if (Day_2 == 0)
            {
                Day_2 = 1;
            }
            else if (Day_3 == 0)
            {
                Day_3 = 1;
            }
            else if (Day_4 == 0)
            {
                Day_4 = 1;
            }
            else if (Day_5 == 0)
            {
                Day_5 = 1;
            }
            else if (Day_6 == 0)
            {
                Day_6 = 1;
            }
            else if (Day_7 == 0)
            {
                Day_7 = 1;
            }



            Reward();
        }
    }


    public void Reward()
    {
        if (Day_1 == 0)
        {
            OFF_1.SetActive(true);
            ACTIVE_1.SetActive(false);
            CHECK_1.SetActive(false);
        }
        if (Day_1 == 1)
        {
            OFF_1.SetActive(false);
            ACTIVE_1.SetActive(true);
            CHECK_1.SetActive(false);
        }
        if (Day_1 == 2)
        {
            OFF_1.SetActive(false);
            ACTIVE_1.SetActive(false);
            CHECK_1.SetActive(true);
        }


        if (Day_2 == 0)
        {
            OFF_2.SetActive(true);
            ACTIVE_2.SetActive(false);
            CHECK_2.SetActive(false);
        }
        if (Day_2 == 1)
        {
            OFF_2.SetActive(false);
            ACTIVE_2.SetActive(true);
            CHECK_2.SetActive(false);
        }
        if (Day_2 == 2)
        {
            OFF_2.SetActive(false);
            ACTIVE_2.SetActive(false);
            CHECK_2.SetActive(true);
        }

        if (Day_3 == 0)
        {
            OFF_3.SetActive(true);
            ACTIVE_3.SetActive(false);
            CHECK_3.SetActive(false);
        }
        if (Day_3 == 1)
        {
            OFF_3.SetActive(false);
            ACTIVE_3.SetActive(true);
            CHECK_3.SetActive(false);
        }
        if (Day_3 == 2)
        {
            OFF_3.SetActive(false);
            ACTIVE_3.SetActive(false);
            CHECK_3.SetActive(true);
        }

        if (Day_4 == 0)
        {
            OFF_4.SetActive(true);
            ACTIVE_4.SetActive(false);
            CHECK_4.SetActive(false);
        }
        if (Day_4 == 1)
        {
            OFF_4.SetActive(false);
            ACTIVE_4.SetActive(true);
            CHECK_4.SetActive(false);
        }
        if (Day_4 == 2)
        {
            OFF_4.SetActive(false);
            ACTIVE_4.SetActive(false);
            CHECK_4.SetActive(true);
        }

        if (Day_5 == 0)
        {
            OFF_5.SetActive(true);
            ACTIVE_5.SetActive(false);
            CHECK_5.SetActive(false);
        }
        if (Day_5 == 1)
        {
            OFF_5.SetActive(false);
            ACTIVE_5.SetActive(true);
            CHECK_5.SetActive(false);
        }
        if (Day_5 == 2)
        {
            OFF_5.SetActive(false);
            ACTIVE_5.SetActive(false);
            CHECK_5.SetActive(true);
        }

        if (Day_6 == 0)
        {
            OFF_6.SetActive(true);
            ACTIVE_6.SetActive(false);
            CHECK_6.SetActive(false);
        }
        if (Day_6 == 1)
        {
            OFF_6.SetActive(false);
            ACTIVE_6.SetActive(true);
            CHECK_6.SetActive(false);
        }
        if (Day_6 == 2)
        {
            OFF_6.SetActive(false);
            ACTIVE_6.SetActive(false);
            CHECK_6.SetActive(true);
        }

        if (Day_7 == 0)
        {
            OFF_7.SetActive(true);
            ACTIVE_7.SetActive(false);
            CHECK_7.SetActive(false);
        }
        if (Day_7 == 1)
        {
            OFF_7.SetActive(false);
            ACTIVE_7.SetActive(true);
            CHECK_7.SetActive(false);
        }
        if (Day_7 == 2)
        {
            OFF_7.SetActive(false);
            ACTIVE_7.SetActive(false);
            CHECK_7.SetActive(true);
        }

    }


    public void GetReward_1()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("Reward 1");

        Day_1 = 2;
        PlayerPrefs.SetInt("Day_1", 2);
        coins.TaskCoins();
        Reward();
    }

    public void GetReward_2()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("Reward 2");

        Day_2 = 2;
        PlayerPrefs.SetInt("Day_2", 2);
        coins.TaskCoins();
        Reward();
    }

    public void GetReward_3()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("Reward 3");

        Day_3 = 2;
        PlayerPrefs.SetInt("Day_3", 2);
        coins.TaskCoins();
        Reward();

    }

    public void GetReward_4()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("Reward 4");

        Day_4 = 2;
        PlayerPrefs.SetInt("Day_4", 2);
        coins.TaskCoins();
        Reward();
    }

    public void GetReward_5()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("Reward 5");

        Day_5 = 2;
        PlayerPrefs.SetInt("Day_5", 2);
        coins.TaskCoins();
        Reward();
    }

    public void GetReward_6()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("Reward 6");

        Day_6 = 2;
        PlayerPrefs.SetInt("Day_6", 2);
        coins.TaskCoins();
        Reward();
    }

    public void GetReward_7()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("Reward 7");

        Day_7 = 2;
        PlayerPrefs.SetInt("Day_7", 2);
        coins.DailyCoins();
        Reward();
    }



}