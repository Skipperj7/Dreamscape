using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupcreate : MonoBehaviour
{


    public List<string> cupsname;
    public List<int> cupsvol;
    public List<cupcreate> cupslist;



    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < cupsname.Count; i++){
            //need to create new var for each cup
            cupcreate test  = new cupcreate(cupsname[i], cupsvol[i], 0);
            cupslist.Add(test);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        //test to see if list works (currently working)

        if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log(cupslist[0].Name);
            Debug.Log(cupslist[0].CurrentVolume);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            getcupandsetvol("testcup", 1);
        }

    }

    public string Name { get; set; }
    public int Volume { get; set; }
    public int CurrentVolume { get; set; }
    public cupcreate(string name, int vol, int curvol)
    {
        Name = name;
        Volume = vol;
        CurrentVolume = curvol;
    }

    public void getcupandsetvol(string c, int i)
    {
        
        foreach(cupcreate t in cupslist){
            if(t.Name == c){
                
                t.CurrentVolume = i;
            }
        }
    }

    public void pour(string othercup, int i){
        
        foreach (cupcreate t in cupslist)
        {
            if (t.Name == othercup)
            {
                if (i + t.CurrentVolume <= t.Volume)
                {
                    t.CurrentVolume = i + t.CurrentVolume;
                }
                else{
                    t.CurrentVolume = t.Volume;
                }
            }
        }
             
            

    }
}


