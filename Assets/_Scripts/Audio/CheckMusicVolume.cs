using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VirtualMuseum.Menu{
public class CheckMusicVolume : MonoBehaviour
{
		public void  Start (){
			// remember volume level from last time
			GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume");
		}

		public void UpdateVolume (){
			GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume");
		}
    }
}
