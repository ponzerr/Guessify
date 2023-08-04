using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyTask : MonoBehaviour
{
   // TASK LAYOUT
	
    public int LastDate;
    public CoinSystem coins;

	public int Task_1;
	public int Task_2;
    public int Task_3;
    public int Task_4;
    public int Task_5;
    public int Task_6;
    public int Task_7;

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
        Task_1 = PlayerPrefs.GetInt("Task_1");
		Task_2 = PlayerPrefs.GetInt("Task_2");
        Task_3 = PlayerPrefs.GetInt("Task_3");
        Task_4 = PlayerPrefs.GetInt("Task_4");
        Task_5 = PlayerPrefs.GetInt("Task_5");
        Task_6 = PlayerPrefs.GetInt("Task_6");
        Task_7 = PlayerPrefs.GetInt("Task_7");

        LastDate = PlayerPrefs.GetInt("LastDate");
		
		Reward();
		
		if(LastDate != System.DateTime.Now.Day)
        {
            if(Task_1 == 0)
            {
                Task_1 = 1;
            }
			else if(Task_2 == 0)
            {
                Task_2 = 1;
            }
            else if (Task_3 == 0)
            {
                Task_3 = 1;
            }
            else if (Task_4 == 0)
            {
                Task_4 = 1;
            }
            else if (Task_5 == 0)
            {
                Task_5 = 1;
            }
            else if (Task_6 == 0)
            {
                Task_6 = 1;
            }
            else if (Task_7 == 0)
            {
                Task_7 = 1;
            }
            Reward();
		}
	}

	public void Reward()
    {
        if(Task_1 == 0)
        {
            OFF_1.SetActive(true);
            ACTIVE_1.SetActive(false);
            CHECK_1.SetActive(false);
        }
        if(Task_1 == 1)
        {
            OFF_1.SetActive(false);		
            ACTIVE_1.SetActive(true);
            CHECK_1.SetActive(false);
        }
		if(Task_1 == 2)
        {
            OFF_1.SetActive(false);
            ACTIVE_1.SetActive(false);
			CHECK_1.SetActive(true);
        }
		//----
		if(Task_2 == 0)
        {
            OFF_2.SetActive(true);
            ACTIVE_2.SetActive(false);
            CHECK_2.SetActive(false);
        }
        if(Task_2 == 1)
        {
            OFF_2.SetActive(false);		
            ACTIVE_2.SetActive(true);
            CHECK_2.SetActive(false);
        }
		if(Task_2 == 2)
        {
            OFF_2.SetActive(false);
            ACTIVE_2.SetActive(false);
			CHECK_2.SetActive(true);
        }
        //----
        if (Task_3 == 0)
        {
            OFF_3.SetActive(true);
            ACTIVE_3.SetActive(false);
            CHECK_3.SetActive(false);
        }
        if (Task_3 == 1)
        {
            OFF_3.SetActive(false);
            ACTIVE_3.SetActive(true);
            CHECK_3.SetActive(false);
        }
        if (Task_3 == 2)
        {
            OFF_3.SetActive(false);
            ACTIVE_3.SetActive(false);
            CHECK_3.SetActive(true);
        }
        //----
        if (Task_4 == 0)
        {
            OFF_4.SetActive(true);
            ACTIVE_4.SetActive(false);
            CHECK_4.SetActive(false);
        }
        if (Task_4 == 1)
        {
            OFF_4.SetActive(false);
            ACTIVE_4.SetActive(true);
            CHECK_4.SetActive(false);
        }
        if (Task_4 == 2)
        {
            OFF_4.SetActive(false);
            ACTIVE_4.SetActive(false);
            CHECK_4.SetActive(true);
        }
        //----
        if (Task_5 == 0)
        {
            OFF_5.SetActive(true);
            ACTIVE_5.SetActive(false);
            CHECK_5.SetActive(false);
        }
        if (Task_5 == 1)
        {
            OFF_5.SetActive(false);
            ACTIVE_5.SetActive(true);
            CHECK_5.SetActive(false);
        }
        if (Task_5 == 2)
        {
            OFF_5.SetActive(false);
            ACTIVE_5.SetActive(false);
            CHECK_5.SetActive(true);
        }
        //----
        if (Task_6 == 0)
        {
            OFF_6.SetActive(true);
            ACTIVE_6.SetActive(false);
            CHECK_6.SetActive(false);
        }
        if (Task_6 == 1)
        {
            OFF_6.SetActive(false);
            ACTIVE_6.SetActive(true);
            CHECK_6.SetActive(false);
        }
        if (Task_6 == 2)
        {
            OFF_6.SetActive(false);
            ACTIVE_6.SetActive(false);
            CHECK_6.SetActive(true);
        }
        //----
        if (Task_7 == 0)
        {
            OFF_7.SetActive(true);
            ACTIVE_7.SetActive(false);
            CHECK_7.SetActive(false);
        }
        if (Task_7 == 1)
        {
            OFF_7.SetActive(false);
            ACTIVE_7.SetActive(true);
            CHECK_7.SetActive(false);
        }
        if (Task_7 == 2)
        {
            OFF_7.SetActive(false);
            ACTIVE_7.SetActive(false);
            CHECK_7.SetActive(true);
        }
    }
	
	public void GetReward_1()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate" , LastDate);

        print("TaskReward 1");
		
		Task_1 = 2;
        PlayerPrefs.SetInt("Task_1" , 2);
        coins.TaskCoins();
        Reward();
       
    }

	//---
	public void GetReward_2()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate" , LastDate);
		
        print("TaskReward 2");
		
		Task_2 = 2;
        PlayerPrefs.SetInt("Task_2" , 2);
        coins.TaskCoins();
        Reward();
    }

    //---
    public void GetReward_3()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("TaskReward 3");

        Task_3 = 2;
        PlayerPrefs.SetInt("Task_3", 2);
        coins.TaskCoins();
        Reward();
    }

    //---
    public void GetReward_4()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("TaskReward 4");

        Task_4 = 2;
        PlayerPrefs.SetInt("Task_4", 2);
        coins.TaskCoins();
        Reward();
    }

    //---
    public void GetReward_5()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("TaskReward 5");

        Task_5 = 2;
        PlayerPrefs.SetInt("Task_5", 2);
        coins.TaskCoins();
        Reward();
    }

    //---
    public void GetReward_6()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("TaskReward 6");

        Task_6 = 2;
        PlayerPrefs.SetInt("Task_6", 2);
        coins.TaskCoins();
        Reward();
    }

    //---
    public void GetReward_7()
    {
        LastDate = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("LastDate", LastDate);

        print("TaskReward 7");

        Task_7 = 2;
        PlayerPrefs.SetInt("Task_7", 2);
        coins.TaskCoins();
        Reward();
    }

}

	
