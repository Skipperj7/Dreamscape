using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maze : MonoBehaviour {


    public string type;
    public float time;
    public mazeclock c;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "player")
        {
            if (type == "start") {
                c.clockon = true;
                c.time = 0f;
                Destroy(gameObject);

            }
            else if(type == "end") {
                c.clockon = false;
                time = c.time;
                Debug.Log("Timestopped: player won in " + time);
                Destroy(gameObject);
            }

        }
    }
   

}
