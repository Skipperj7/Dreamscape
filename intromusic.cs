using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intromusic : MonoBehaviour {

	public AudioSource audioc;
	public Graphic img;
	private float alpha = 1.0f;
	public float duration;
	// Use this for initialization
	void Start () {
		StartCoroutine (wait ());

	}

	IEnumerator wait(){
		Color currentColor = img.color;
		Color visibleColor = img.color;
		visibleColor.a = alpha;
		float counter = 0;
		while (counter < duration)
		{
			counter += Time.deltaTime;
			img.color = Color.Lerp(currentColor, visibleColor, counter / duration);
			yield return null;
		}

		audioc.Play (0);
	}
	
	// Update is called once per frame
	void Update () {
		


	}
}
