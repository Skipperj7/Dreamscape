using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{


    public string type;
    private bool up;
    Vector3 originalmouse;
    Vector3 originalblock;
    // Use this for initialization
    void Start()
    {
        switch (type)
        {
            case "vertical":
                up = true;
                break;

            case "horizontal":
                up = false;
                break;
        }
        GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            originalmouse = Input.mousePosition;
            originalblock = gameObject.transform.position;
        }

        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            if (up)
            {
                if (originalmouse.y > Input.mousePosition.y)
                {
                    transform.Translate(Vector2.down * (originalmouse.y - Input.mousePosition.y) / 1.25f * Time.deltaTime);
                }
                else if (originalmouse.y < Input.mousePosition.y)
                {
                    transform.Translate(Vector2.up * (Input.mousePosition.y - originalmouse.y) / 1.25f * Time.deltaTime);
                }
            }
            else
            {
                if (originalmouse.x > Input.mousePosition.x)
                {
                    transform.Translate(Vector2.left * (originalmouse.x - Input.mousePosition.x) / 1.25f * Time.deltaTime);
                }
                else if (originalmouse.x < Input.mousePosition.x)
                {
                    transform.Translate(Vector2.right * (Input.mousePosition.x - originalmouse.x) / 1.25f * Time.deltaTime);
                }
            }
            originalmouse = Input.mousePosition;
        }
        else
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
}
