using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	public Button startbutton;
	public BackgroundMechanics script;

	public GameObject decidecanvas;
	public Button no;
	public Button yes;
	// Use this for initialization
	void Start () {
		decidecanvas.SetActive (false);
		startbutton.onClick.AddListener (startsave);
		no.onClick.AddListener (dno);
		yes.onClick.AddListener (dyes);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void startsave(){
		if (File.Exists (Application.persistentDataPath + "/gamedata.dat")) {
			decidecanvas.SetActive (true);
		} 
		else {
			script.test = true;
			script.save ();
			SceneManager.LoadScene (1);
		}

	}

	void dyes(){
		//for testing
		script.test = true;
		script.save ();

		//keep
		script.load ();
		SceneManager.LoadScene (1);
	}

	void dno(){
		script.clearsave ();
		script.save ();
		SceneManager.LoadScene (1);
	}
}
