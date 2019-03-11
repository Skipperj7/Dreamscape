using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intromusic : MonoBehaviour {

	public AudioSource audioc;
	public Graphic img;
	private float alpha = 1.0f;
	public float duration;
	public Graphic startbuttonimg;
	public Graphic settingsbuttonimg;
	public Graphic shopbuttonimg;
	public Text startbuttontext;
	public Text settingsbuttontext;
	public Text shopbuttontext;
	// Use this for initialization
	void Start () {
		var tempColor = img.color;
		tempColor.a = 0.0f;
		img.color = tempColor;
		tempColor = startbuttonimg.color;
		tempColor.a = 0.0f;
		startbuttonimg.color = tempColor;
		tempColor = settingsbuttonimg.color;
		tempColor.a = 0.0f;
		settingsbuttonimg.color = tempColor;
		tempColor = shopbuttonimg.color;
		tempColor.a = 0.0f;
		shopbuttonimg.color = tempColor;

		tempColor = startbuttontext.color;
		tempColor.a = 0.0f;
		startbuttontext.color = tempColor;
		tempColor = settingsbuttontext.color;
		tempColor.a = 0.0f;
		settingsbuttontext.color = tempColor;
		tempColor = shopbuttontext.color;
		tempColor.a = 0.0f;
		shopbuttontext.color = tempColor;

		StartCoroutine (wait ());

	}

	IEnumerator wait(){
		Color currentColor = img.color;
		Color visibleColor = img.color;
		visibleColor.a = alpha;

		Color currentColor1 = startbuttonimg.color;
		Color visibleColor1 = startbuttonimg.color;
		visibleColor1.a = alpha;

		Color currentColor2 = settingsbuttonimg.color;
		Color visibleColor2 = settingsbuttonimg.color;
		visibleColor2.a = alpha;

		Color currentColor3 = shopbuttonimg.color;
		Color visibleColor3 = shopbuttonimg.color;
		visibleColor3.a = alpha;

		Color currentColor4 = startbuttontext.color;
		Color visibleColor4 = startbuttontext.color;
		visibleColor4.a = alpha;

		Color currentColor5 = settingsbuttontext.color;
		Color visibleColor5 = settingsbuttontext.color;
		visibleColor5.a = alpha;

		Color currentColor6 = shopbuttontext.color;
		Color visibleColor6 = shopbuttontext.color;
		visibleColor6.a = alpha;

		float counter = 0;
		while (counter < duration)
		{
			counter += Time.deltaTime;
			img.color = Color.Lerp(currentColor, visibleColor, counter / duration);
			startbuttonimg.color = Color.Lerp (currentColor1, visibleColor1, counter / duration);
			settingsbuttonimg.color = Color.Lerp (currentColor2, visibleColor2, counter / duration);
			shopbuttonimg.color = Color.Lerp (currentColor3, visibleColor3, counter / duration);
			startbuttontext.color = Color.Lerp (currentColor4, visibleColor4, counter / duration);
			settingsbuttontext.color = Color.Lerp (currentColor5, visibleColor5, counter / duration);
			shopbuttontext.color = Color.Lerp (currentColor6, visibleColor6, counter / duration);


			yield return null;
		}

		audioc.Play (0);
	}
	
	// Update is called once per frame
	void Update () {
		


	}

	void startgame(){
		
	}

}
