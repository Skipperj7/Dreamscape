using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour {

	public Image hair;
	public Image shirt;
	public Image pants;
	public Image shoes;
	public BackgroundMechanics script;

	private List<string> hairlist;
	private List<string> shirtlist;
	private List<string> pantslist;
	private List<string> shoeslist;

	private List<string> hairlistunlocked;
	private List<string> shirtlistunlocked;
	private List<string> pantslistunlocked;
	private List<string> shoeslistunlocked;

	private int hairselected;
	private int shirtselected;
	private int pantsselected;
	private int shoesselected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void spinthrough(Image i){
		//get children of image (right/left buttons)
	}

	void findunlocked(Image i){
		//compare locked to unlocked to see if item is unlocked
	}

	//access backgroundmechanics data to save unlocked
}
