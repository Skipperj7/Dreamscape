using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectmissing : MonoBehaviour {

    private Button btn;
    public clickonmissing s;
	// Use this for initialization
	void Start () {
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(clicked);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void clicked(){
        s.spritenumber++;
        Destroy(gameObject);
    }

}
