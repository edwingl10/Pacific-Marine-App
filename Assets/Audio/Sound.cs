﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]  // add it so that unity knows the class
public class Sound {

	public string name;

	public AudioClip clip;

	[Range(0f, 1f)]   // slider
	public float volume = .75f;
	[Range(0f, 1f)]
	public float volumeVariance = .1f;

	[Range(.1f, 3f)]
	public float pitch = 1f;
	[Range(0f, 1f)]
	public float pitchVariance = .1f;

	public bool loop = false;

	public AudioMixerGroup mixerGroup;

    // don't want the inspector to show at the beginning
    [HideInInspector]  
	public AudioSource source;

}
