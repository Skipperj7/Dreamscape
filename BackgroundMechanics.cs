using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class BackgroundMechanics : MonoBehaviour {

	public bool test = false;
	public float musicvol;
	public float soundeffectvol;

	// Use this for initialization
	void Start () {

        load();
		
		if (test == true) {
			Debug.Log("load worked");
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log (musicvol);
        /*
        if (Input.GetKey(KeyCode.C)) {
            clearsave();
        }
        if (Input.GetKey(KeyCode.V))
        {
            save();
        }
        */

    }

	public void save(){
		BinaryFormatter saver = new BinaryFormatter ();
		FileStream file = File.Open (Application.persistentDataPath + "/gamedata.dat", FileMode.OpenOrCreate);

		data playerdata = new data ();
        test = true;
		playerdata.test = test;

		playerdata.musicvol = musicvol;
		playerdata.soundeffectvol = soundeffectvol;

		
		saver.Serialize (file, playerdata);

		file.Close ();
        Debug.Log("saved");
        if (File.Exists(Application.persistentDataPath + "/gamedata.dat"))
        {
           
            Debug.Log("save worked");

        }

    }

	public void load(){
		try{
			BinaryFormatter saver = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/gamedata.dat", FileMode.Open);
			data playerdata = (data)saver.Deserialize(file);
			file.Close();

			test = playerdata.test;

			musicvol = playerdata.musicvol;
			soundeffectvol = playerdata.soundeffectvol;
           
            Debug.Log("loaded");
        }
		catch(Exception){
			Debug.Log ("load failed");
		}
	}

	public void clearsave(){
		if (File.Exists (Application.persistentDataPath + "/gamedata.dat")) {
			File.Delete (Application.persistentDataPath + "/gamedata.dat");
            test = false;
            Debug.Log("cleared save");
        
        }
	}
}

[Serializable]
public class data{
	public bool test;
	public float musicvol;
	public float soundeffectvol;
}