using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class optmeter : MonoBehaviour
{

    public Slider meter;
    public Image filling;
    public float optimism;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float i = meter.value;
        if (i > .75)
        {
            filling.color = Color.green;
        }
        else if (i > .50)
        {
            filling.color = Color.blue;
        }
        else if (i > .25)
        {
            filling.color = Color.yellow;
        }
        else
        {
            filling.color = Color.red;
        }
    }






}
