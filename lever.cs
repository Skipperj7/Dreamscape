using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour {

    public GameObject maze;
    public GameObject player;
    public string levername;
    private bool onoff;
    public Vector2 position;
    public float angle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(onoff){
            if(Input.GetKeyDown(KeyCode.E)){
                Debug.Log("pressed");
                changemaze(levername);
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision start");
        if(collision.gameObject.tag == "player"){
            onoff = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("collision end");
        if (collision.gameObject.tag == "player")
        {
            onoff = false;
        } 
    }


    void changemaze(string m){
        switch(m){
            case "Maze 1 Level 1":
                int i = maze.transform.childCount;
                for (int l = 0; l < i; l++)
                {
                    maze.transform.GetChild(l).gameObject.transform.RotateAround(position, Vector3.forward, angle);
                }
                break;
        }
    }
}
