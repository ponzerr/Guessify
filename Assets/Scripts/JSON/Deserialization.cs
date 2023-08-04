using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Deserialization : MonoBehaviour
{
    [SerializeField] public LevelData objects;
    [SerializeField] private GameObject[] starStatus;


    [SerializeField] private int index = 0;
    public void Start()
    {
        
        objects = DataPersistenceManager.instance.data.GetLevel(index);
        int threestar = objects.starcount;
        Debug.Log(threestar);

        if (threestar == 3)
        {
            starStatus[2].SetActive(true);
            starStatus[1].SetActive(true);
            starStatus[0].SetActive(true);
        }
        else if (threestar == 2)
        {

            starStatus[2].SetActive(true);
            starStatus[0].SetActive(true);
        }
        else if (threestar == 1)
        {
            starStatus[0].SetActive(true);
        }

    }

}
