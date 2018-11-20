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
	public Text startbuttontext;
	public Text settingsbuttontext;
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
		tempColor = startbuttontext.color;
		tempColor.a = 0.0f;
		startbuttontext.color = tempColor;
		tempColor = settingsbuttontext.color;
		tempColor.a = 0.0f;
		settingsbuttontext.color = tempColor;
		StartCoroutine (wait ());

	}

	IEnumerator wait(){
		Color currentColor = img.color;
		Color visibleColor = img.color;
		visibleColor.a = alpha;

		Color currentColor1 = img.color;
		Color visibleColor1 = img.color;
		visibleColor1.a = alpha;

		Color currentColor2 = img.color;
		Color visibleColor2 = img.color;
		visibleColor2.a = alpha;

		Color currentColor3 = img.color;
		Color visibleColor3 = img.color;
		visibleColor3.a = alpha;

		Color currentColor4 = img.color;
		Color visibleColor4 = img.color;
		visibleColor4.a = alpha;

		float counter = 0;
		while (counter < duration)
		{
			counter += Time.deltaTime;
			img.color = Color.Lerp(currentColor, visibleColor, counter / duration);
			startbuttonimg.color = Color.Lerp (currentColor1, visibleColor1, counter / duration);
			settingsbuttonimg.color = Color.Lerp (currentColor2, visibleColor2, counter / duration);
			startbuttontext.color = Color.Lerp (currentColor3, visibleColor3, counter / duration);
			settingsbuttontext.color = Color.Lerp (currentColor4, visibleColor4, counter / duration);



			yield return null;
		}

		audioc.Play (0);
	}
	
	// Update is called once per frame
	void Update () {
		


	}
}
