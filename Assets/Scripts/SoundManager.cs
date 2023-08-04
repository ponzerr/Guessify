using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
	[SerializeField] AudioSource click;
	[SerializeField] Image SoundOn;
	[SerializeField] Image SoundOff;
	private bool muted2 = false;
	
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted2"))
		{
			PlayerPrefs.SetInt("muted2", 0);
			Load();
		}
		
		else
		{
			Load();
		}
		UpdateButtonIcon();
		click.mute = muted2;
    }

    // Update is called once per frame
    public void OnButtonPress()
    {
        if(muted2 == false)
		{
			muted2 = true;
			click.mute = true;
		}
		
		else 
		{
			muted2 = false;
			click.mute = false;
		}
		
		Save();
		UpdateButtonIcon();
    }
	
	private void UpdateButtonIcon()
	{
		if(muted2 == false)
		{
			SoundOn.enabled = true;
			SoundOff.enabled = false;
		}
		
		else
		{
			SoundOn.enabled = false;
			SoundOff.enabled = true;			
		}
	}
	
	private void Load()
	{
		muted2 = PlayerPrefs.GetInt("muted2") == 1;
	}

	private void Save()
	{
		PlayerPrefs.SetInt("muted2", muted2 ? 1 : 0);
	}
}
