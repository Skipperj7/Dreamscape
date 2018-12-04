using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup : MonoBehaviour
{


    public List<string> cupsname;
    public List<int> cupsvol;




    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < cupsname.Count; i++){
           cup test  = new cup(cupsname[i], cupsvol[i]);
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public string Name { get; set; }
    public int Volume { get; set; }
    public cup() { }
    public cup(string name, int age)
    {
        Name = name;
        Volume = age;
    }

    void getcup(string cupname)
    {
        
    }
}


