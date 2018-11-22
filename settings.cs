﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour {

	public GameObject settingscanvas;
	public Button settingsbuton;
	public Button backbutton;
	public Button resetgame;
	public Slider musicslider;
	public Slider soundeffectsslider;
	public AudioSource music;
	public AudioSource soundeffects;

	// Use this for initialization
	void Start () {
		settingsbuton.onClick.AddListener (open);
		backbutton.onClick.AddListener (close);
		settingscanvas.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		music.volume = (musicslider.value / 100);
		soundeffects.volume = (soundeffectsslider.value / 100);
	}

	void open(){
		settingscanvas.SetActive (true);
	}

	void close(){
		settingscanvas.SetActive (false);
	}

	//reset game button needs to be implemented after saving has been figured out

}
