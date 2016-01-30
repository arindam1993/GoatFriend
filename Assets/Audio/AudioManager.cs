﻿using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
//#if UNITY_EDITOR
//using UnityEditor
//#endif


public class AudioManager : MonoBehaviour {

	// Use this for initialization
	public AudioSource efxSource;
	public AudioSource musicSource; 


	public AudioMixerSnapshot paused; 
	public AudioMixerSnapshot unpaused; 

	// Singleton
	public static AudioManager instance = null;

	// pitch variations for pitch of sound effects
	public float lowPitchRange = .95f; 
	public float highPitchRange = 1.05f;


	void Awake () {
		if (instance = null) {
			instance = this;
			print ("sdfasd"); 
		}
//		} else if (instance != this) {
//			Destroy (gameObject);
//			print ("DFJD"); 
//		}
		
//		DontDestroyOnLoad (gameObject); 
//		musicSource.Play (); 
	}


	public void PlaySingleClip (AudioClip clip) {
		efxSource.clip = clip;
		efxSource.Play();
	}
		
	// can input objects as a comma separated list
	// and will be inserted into the array because of params keyword
	public void RandomizeSfx(params AudioClip[] clips) {
		int randomIndex = Random.Range (0, clips.Length); 
		float randomPitch = Random.Range(lowPitchRange, highPitchRange);
			
		efxSource.pitch = randomPitch;
		efxSource.clip = clips [randomIndex];
		efxSource.Play (); 
	}


	// call this when pause has been done
	public void playPauseSound() {
		paused.TransitionTo (.01f);
//		if (Time.timeScale == 0) {
//			// Lowpass ();
//			paused.TransitionTo(.01f); 
//		}
//		else {
//			unpaused.TransitionTo(.01f); 
//		}
	}

	public void unPausedMusic() {
		unpaused.TransitionTo (.01f);
	}

	public void level1Transition() {
		
	}

	public void level2Transition() {
	}

	public void level3Transition() {
	}

	public void level4Transition() {
	}

		
}
