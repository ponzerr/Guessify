using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private static Sound sound;
	
    void Awake()
    {
        if(sound == null)
		{
			sound = this;
			DontDestroyOnLoad(sound);
		}
		
		 else
		{
			Destroy(gameObject); 
		}
    }
}
