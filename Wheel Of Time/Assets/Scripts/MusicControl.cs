using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicControl : MonoBehaviour {
	public bool musicOn;
	public Slider volumeSlider;
	public AudioSource volumeAudio;

	public void OnValueChanged(){
		volumeAudio.volume = volumeSlider.value;
	}

	public void volumeOn(){
		volumeAudio.volume = volumeSlider.value;
	}

	public void volumeOff(){
		volumeAudio.volume = 0;
	}
}
