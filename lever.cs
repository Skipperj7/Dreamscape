using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lever : MonoBehaviour {


	public List<GameObject> maze;
    public GameObject player;
    public string levername;
    private bool onoff;
    public Vector2 position;
    
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
		case "Maze 1 Lever 1":
			GameObject g = maze [0];
			int i = g.transform.childCount;
			for (int l = 0; l < i; l++) {
				g.transform.GetChild (l).gameObject.transform.RotateAround (position, Vector3.forward, 90);
			}
			g = maze [1];
			i = g.transform.childCount;
			for (int l = 0; l < i; l++) {
				g.transform.GetChild (l).gameObject.transform.RotateAround (position, Vector3.forward, -90);
			}
			Destroy (gameObject);
                break;
		case "back":
			SceneManager.LoadScene (0);
			break;
            case "forward":
                SceneManager.LoadScene(2);
                break;
        }
        Destroy(GetComponent<lever>());
    }
}
