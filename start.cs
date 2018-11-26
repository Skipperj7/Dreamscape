using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
		decidecanvas.SetActive (true);

	}

	void dyes(){
		//for testing
		script.test = true;
		script.save ();

		//keep
		script.load ();
	}

	void dno(){
		script.clearsave ();
	}
}
