using System.Collections;
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
	public BackgroundMechanics script;

    public Button startbtn;
    public Button setbtn;
    public Button shopbtn;

	// Use this for initialization
	void Start () {
		settingsbuton.onClick.AddListener (open);
		backbutton.onClick.AddListener (close);
		settingscanvas.SetActive (false);
		resetgame.onClick.AddListener (reset);

		script.load ();
       
		musicslider.value = script.musicvol;

		soundeffectsslider.value = script.soundeffectvol;
        tempmusic = musicslider.value;
        tempsoundeffects = soundeffectsslider.value;
	}
    float tempmusic;
    float tempsoundeffects;
	// Update is called once per frame
	void Update () {
        
		music.volume = (musicslider.value);
		script.musicvol = music.volume;
		soundeffects.volume = (soundeffectsslider.value);
		script.soundeffectvol = soundeffects.volume;
        if(tempmusic != music.volume || tempsoundeffects != soundeffects.volume) {
            script.save();
        }
        tempmusic = music.volume;
         tempsoundeffects = soundeffects.volume;
	}

	void open(){
		settingscanvas.SetActive (true);
        startbtn.enabled = false;
        setbtn.enabled = false;
        shopbtn.enabled = false;
    }

	void close(){
		settingscanvas.SetActive (false);
        startbtn.enabled = true;
        setbtn.enabled = true;
        shopbtn.enabled = true;
    }


	void reset(){
		script.clearsave ();
		close ();
	}
}
