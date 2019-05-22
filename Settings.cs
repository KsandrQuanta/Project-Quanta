using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;


public class Settings : MonoBehaviour {
    public AudioMixer am;
    public bool isFullScreen;
    public void AudioVolume(float sliderValue){
        am.SetFloat("masterVolume", sliderValue);
    }
    public void FullScreenToggle() {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
    
		
	
}
