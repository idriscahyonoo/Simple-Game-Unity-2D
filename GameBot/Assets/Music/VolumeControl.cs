﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour {

	public AudioMixer myMixer;
	private GameObject panel;
	private bool isPaused = false;
	// Use this for initialization
	void Start () {
		panel = GameObject.Find ("Panel");
		//panel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if	(Input.GetKeyUp(KeyCode.Escape))
		{
			
			panel.SetActive (!panel.activeInHierarchy);
			if(isPaused)
			Time.timeScale = 1.0f;
		else
			Time.timeScale = 0.0f;
			isPaused = !isPaused;
		}
	}

	public void Mute()
	{
		AudioListener.pause = !AudioListener.pause;
	}

	public void ChangeMusicVol(float vol)
	{
		myMixer.SetFloat("MusicVolume",	Mathf.Log10(vol) * 20f);		
	}
	
	public void ChangeFxVol(float vol)
	{
		myMixer.SetFloat("FxVolume", Mathf.Log10(vol) * 20f);
	}
	
	public void ChangeOverallVol(float vol)
	{
		myMixer.SetFloat("OverallVolume", Mathf.Log10(vol) * 20f);
	}
}
