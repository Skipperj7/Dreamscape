using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class BackgroundMechanics : MonoBehaviour {

	public bool test;


	// Use this for initialization
	void Start () {
		


		if (test == true) {
			Debug.Log("load worked");
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void save(){
		BinaryFormatter saver = new BinaryFormatter ();
		FileStream file = File.Open (Application.persistentDataPath + "/gamedata.dat", FileMode.OpenOrCreate);

		data playerdata = new data ();

		playerdata.test = test;

		saver.Serialize (file, playerdata);
		file.Close ();

	}

	public void load(){
		try{
			BinaryFormatter saver = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/gamedata.dat", FileMode.Open);
			data playerdata = (data)saver.Deserialize(file);
			file.Close();

			test = playerdata.test;
		}
		catch(Exception){
			Debug.Log ("load failed");
		}
	}

	public void clearsave(){
		if (File.Exists (Application.persistentDataPath + "/gamedata.dat")) {
			File.Delete (Application.persistentDataPath + "/gamedata.dat");
		}
	}
}

[Serializable]
public class data{
	public bool test;
}