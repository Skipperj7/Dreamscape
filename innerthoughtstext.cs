using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class innerthoughtstext : MonoBehaviour
{

    public Graphic img;
    private float alpha = 1.0f;
    public float duration;
    public string scenename;
    public List<GameObject> thoughts;
    public List<Graphic> buttons;
    public List<Graphic> other;
    public GameObject mindcanvas;
    public int sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject g in thoughts) {
            g.SetActive(false);
        }
        foreach (Graphic g in buttons)
        {
            g.gameObject.SetActive(false);
            g.gameObject.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(transion(g.gameObject.name)); });
            
        }
        foreach (Graphic g in other)
        {
            g.gameObject.SetActive(false);

        }
        StartCoroutine(switchtext());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator switchtext() {
        int c = 0;
        switch (scenename)
        {

            case "scene 1 thoughts":
                //Debug.Log("passed switch");
              

                 c = 0;

                foreach (GameObject g in thoughts)
                {
                    if(c == 0 || c == 1 || c == 8 || c == 9 || c == 12) {
                        duration = 4;
                        g.SetActive(true);
                        fadein(g.GetComponent<Text>());
                        yield return new WaitForSeconds(4f);
                        fadeout(g.GetComponent<Text>());
                        //thoughts[0].SetActive(false);
                        yield return new WaitForSeconds(4f);
                    }
                    else {
                        duration = 2.5f;
                        g.SetActive(true);
                        fadein(g.GetComponent<Text>());
                        yield return new WaitForSeconds(2f);
                        fadeout(g.GetComponent<Text>());
                        //thoughts[0].SetActive(false);
                        yield return new WaitForSeconds(2.5f);
                    }
                    c++;
                }


                /*
                duration = 4;
                buttons[0].gameObject.SetActive(true);
                buttons[1].gameObject.SetActive(true);
                fadein(buttons[0].GetComponent<Text>());
                fadein(buttons[1].GetComponent<Text>());
                */
                duration = 4;
                foreach (Graphic g in buttons) {
                 g.gameObject.SetActive(true);
                 fadein(g.GetComponent<Graphic>());

                }

               
                yield return null;
                //yield return new WaitForSeconds(1f);





                break;

            
        }
       
    }

    void fadein(Graphic t) {
        //Debug.Log("passed fadein");
        var tempColor = t.color;
        tempColor.a = 0.0f;

        t.color = tempColor;
        tempColor = t.color;
        tempColor.a = 0.0f;
        StartCoroutine(fadeinienum(t));

    }

    IEnumerator fadeinienum(Graphic t) {
        //Debug.Log("passed fadeinienum");
        Color currentColor6 = t.color;
        Color visibleColor6 = t.color;
        visibleColor6.a = alpha;

        float counter = 0;
        while (counter < duration)
        {
            counter += Time.deltaTime;

            t.color = Color.Lerp(currentColor6, visibleColor6, counter / duration);


            yield return false;
        }
        yield return true;

    }

    void fadeout(Graphic t) {
        //Debug.Log("passed fadein");
        var tempColor = t.color;
        tempColor.a = 1.0f;

        t.color = tempColor;
        tempColor = t.color;
        tempColor.a = 1.0f;
        StartCoroutine(fadeoutienum(t));

    }

    IEnumerator fadeoutienum(Graphic t) {
        Color currentColor6 = t.color;
        Color visibleColor6 = t.color;
        visibleColor6.a = alpha - 1;

        float counter = 0;
        while (counter < duration)
        {
            counter += Time.deltaTime;

            t.color = Color.Lerp(currentColor6, visibleColor6, counter / duration);


            yield return null;
        }
    }

    IEnumerator transion(string Bname) {
        foreach (Graphic g in buttons)
        {
            g.gameObject.SetActive(false);

        }
        switch (Bname) {
            case "stay in bed":
                duration = 4;
                other[0].gameObject.SetActive(true);
                fadein(other[0].GetComponent<Graphic>());
                yield return new WaitForSeconds(4f);
                SceneManager.LoadScene(sceneToLoad);
                break;
            case "get out of bed":
                SceneManager.LoadScene(sceneToLoad);
                break;
            
        }
        yield return null;
    }
}
