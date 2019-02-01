using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csichartbutton : MonoBehaviour
{
    public SpriteRenderer btn;
    public Sprite check;
    public Sprite blank;
    public Sprite x;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (btn.sprite == check)
            {
                btn.sprite = blank;
            }
            else
            {
                btn.sprite = check;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (btn.sprite == x)
            {
                btn.sprite = blank;
            }
            else
            {
                btn.sprite = x;
            }
        }
    }


}
