using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData
{
    public int starcount;
    
	//
    
    public LevelData()
    {
        this.starcount = 0; 
    }
}

[System.Serializable]
public class GameData
{
    [SerializeField]

    private List<LevelData> levels = new List<LevelData> ();

    public LevelData GetLevel(int index)
    {
        if (index < 0 || index >= levels.Count)
        { 
            int difference = (index+ 1) - levels.Count;
            addslots(difference);

            Debug.Log("Adding new Slots");
        }
        
        return levels[index];
    }

    public void SetLevel(int index, LevelData leveldata)
    {
        if (index < 0 || index >= levels.Count)
        {
            int difference = (index + 1) - levels.Count;
            addslots(difference);

            Debug.Log("Adding new Slots");
        }

         levels[index] = leveldata;
    }

    private void addslots(int count)
    {
        for (int i = 0; i < count; i++)
        { 
            levels.Add (new LevelData ());
        }


    }

    
    
}