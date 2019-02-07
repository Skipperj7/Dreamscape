using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeclock : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(clock());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float time;
    public bool clockon;
    public IEnumerator clock()
    {
        if (clockon)
        {
            yield return new WaitForSeconds(.01f);
            time = time + .01f;
           

        }
        yield return new WaitForSeconds(0f);
        StartCoroutine(clock());

    }
}
