using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BGMManager : MonoBehaviour
{
	[SerializeField] AudioSource music;
	[SerializeField] Image BGMOn;
	[SerializeField] Image BGMOff;
	private bool muted = false;
	
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
		{
			PlayerPrefs.SetInt("muted", 0);
			Load();
		}
		
		else
		{
			Load();
		}
		UpdateButtonIcon();
		music.mute = muted;
    }

    // Update is called once per frame
    public void OnButtonPress()
    {
        if(muted == false)
		{
			muted = true;
			music.mute = true;
		}
		
		else 
		{
			muted = false;
			music.mute = false;
		}
		
		Save();
		UpdateButtonIcon();
    }
	
	private void UpdateButtonIcon()
	{
		if(muted == false)
		{
			BGMOn.enabled = true;
			BGMOff.enabled = false;
		}
		
		else
		{
			BGMOn.enabled = false;
			BGMOff.enabled = true;			
		}
	}
	
	private void Load()
	{
		muted = PlayerPrefs.GetInt("muted") == 1;
	}

	private void Save()
	{
		PlayerPrefs.SetInt("muted", muted ? 1 : 0);
	}
}
