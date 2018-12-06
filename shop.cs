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

	private static List<string> hairlist;
	private static List<string> shirtlist;
	private static List<string> pantslist;
	private static List<string> shoeslist;

	private static List<string> hairlistunlocked;
	private static List<string> shirtlistunlocked;
	private static List<string> pantslistunlocked;
	private static List<string> shoeslistunlocked;

	private int hairselected;
	private int shirtselected;
	private int pantsselected;
	private int shoesselected;


	public Button hairright;
	public Button shirtright;
	public Button pantsright;
	public Button shoesright;
	public Button hairleft;
	public Button shirtleft;
	public Button pantsleft;
	public Button shoesleft;

	public Button shopbutton;

	// Use this for initialization
	void Start () {
		shopbutton.onClick.AddListener (openshop);

		hairright.onClick.AddListener (delegate{spinthrough("hair", 1);});
		shirtright.onClick.AddListener (delegate{spinthrough("shirt", 1);});
		pantsright.onClick.AddListener (delegate{spinthrough("pants", 1);});
		shoesright.onClick.AddListener (delegate{spinthrough("shoes", 1);});
		hairleft.onClick.AddListener (delegate{spinthrough("hair", -1);});
		shirtleft.onClick.AddListener (delegate{spinthrough("shirt", -1);});
		pantsleft.onClick.AddListener (delegate{spinthrough("pants", -1);});
		shoesleft.onClick.AddListener (delegate{spinthrough("shoes", -1);});
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void spinthrough(string str, int i){
		//get children of image (right/left buttons)

		switch (str) {
		case "hair":

			break;
		case "shirt":

			break;

		case "pants":

			break;

		case "shoes":

			break;
		}


	}

	static bool findunlocked(string str, int i){
		//compare locked to unlocked to see if item is unlocked
		switch (str) {
		case "hair":
			if(hairlist[i] == hairlistunlocked[i]){
				return true;
			}
			else{
				return false;
			}

		case "shirt":
			if(shirtlist[i] == shirtlistunlocked[i]){
				return true;
			}
			else{
				return false;
			}


		case "pants":
			if(pantslist[i] == pantslistunlocked[i]){
				return true;
			}
			else{
				return false;
			}


		case "shoes":
			if(shoeslist[i] == shoeslistunlocked[i]){
				return true;
			}
			else{
				return false;
			}

		default:
			return false;	
		
		}

	}

	void openshop(){
		
	}

	//access backgroundmechanics data to save unlocked
}
