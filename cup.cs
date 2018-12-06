using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class cup : MonoBehaviour
{


    public cupcreate script;


    public int volume;
    private int currentvol;
    public string Name;

    public Button thiscup;

    public GameObject thisoptionscanvas;
    public GameObject game;
    public Button thisfill;
    public Button thispour;
    public Button thisempty;

    // Use this for initialization
    void Start()
    {
        thiscup.onClick.AddListener(select);
        thisoptionscanvas.SetActive(false);
        try
        {
            script.getcupandsetvol("testcup", 3);
        }
        catch(Exception){
            Debug.Log("error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (cupcreate t in script.cupslist)
        {
            if (t.Name == Name)
            {

                currentvol = t.CurrentVolume;
            }
        }
        thiscup.transform.GetComponentInChildren<Text>().text = currentvol.ToString();

    }

    void select()
    {
        thisoptionscanvas.SetActive(true);
    }

    void fill()
    {
        script.getcupandsetvol(Name, volume);
        thisoptionscanvas.SetActive(false);
    }

    void empty()
    {
        script.getcupandsetvol(Name, 0);
        thisoptionscanvas.SetActive(false);
    }

    void pour()
    {
        string othercup;
        bool selectpour = true;
        thisoptionscanvas.SetActive(false);
        for (int i = 0; i < game.transform.childCount; i++)
        {
            if (game.transform.GetChild(i).gameObject != this.gameObject)
            {
                game.transform.GetChild(i).gameObject.GetComponent<cup>().enabled = false;
            }
        }
        while (selectpour)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    for (int i = 0; i < game.transform.childCount; i++)
                    {
                        if (hit.transform.gameObject.name == game.transform.GetChild(i).gameObject.name)
                        {
                            othercup = game.transform.GetChild(i).gameObject.name;
                            selectpour = false;
                            script.pour(othercup, currentvol);
                            break;
                        }

                    }
                }
            }
        }
        for (int i = 0; i < game.transform.childCount; i++)
        {
            if (game.transform.GetChild(i).gameObject != this.gameObject)
            {
                game.transform.GetChild(i).gameObject.GetComponent<cup>().enabled = true;
            }
        }





        
    }
}

