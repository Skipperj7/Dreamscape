using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class door : MonoBehaviour
{

    public string doorname;
    public List<Button> options;
    public int nextscene;
    public GameObject player;
    public GameObject buttons;
    public Graphic thoughtstext;
    public GameObject thoughttextcan;
    public Graphic img;
    private float alpha = 1.0f;
    public float duration;
    // Start is called before the first frame update
    void Start()
    {
        buttons.SetActive(false);
        thoughttextcan.SetActive(false);
        foreach (Button b in options) {
            b.onClick.AddListener(delegate { transport(doorname, b.name); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == player) {
            buttons.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            buttons.SetActive(false);
        }
    }


    void transport(string lvl, string btn)
    {
        switch (lvl)
        {
            case "scene 1 bedroom":
                StartCoroutine(transportcalls(btn));
                break;

        }
    }



    //  put script in (example voices)
    //              ||
    //              ||
    //              ||
    //              \/
        IEnumerator transportcalls( string btn) {
        duration = 2.5f;
        switch (btn)
            {
                case "voices":
                    buttons.SetActive(false);
                    thoughttextcan.SetActive(true);
                    thoughtstext.GetComponent<Text>().text = "Alright you useless rock, go be useless outside";
                    thoughtstext.gameObject.SetActive(true);
                    fadein(thoughtstext.GetComponent<Text>());
                    yield return new WaitForSeconds(2f);
                    fadeout(thoughtstext.GetComponent<Text>());
                    yield return new WaitForSeconds(2.5f);

                    thoughtstext.GetComponent<Text>().text = "I'm feeling pretty bad";
                    fadein(thoughtstext.GetComponent<Text>());
                    yield return new WaitForSeconds(2f);
                    fadeout(thoughtstext.GetComponent<Text>());
                    yield return new WaitForSeconds(2.5f);

                    thoughtstext.GetComponent<Text>().text = "At least if I go to school I can accomplish something";
                    fadein(thoughtstext.GetComponent<Text>());
                    yield return new WaitForSeconds(2f);
                    fadeout(thoughtstext.GetComponent<Text>());
                    yield return new WaitForSeconds(2.5f);

                SceneManager.LoadScene(nextscene);
                    break;
                case "steps":
                    buttons.SetActive(false);

                    SceneManager.LoadScene(nextscene);
                    break;
                case "bribe":
                    buttons.SetActive(false);

                    SceneManager.LoadScene(nextscene);
                    break;
                case "look forward":
                    buttons.SetActive(false);

                    SceneManager.LoadScene(nextscene);
                    break;
            }
        }
    


    void fadein(Graphic t)
    {
        //Debug.Log("passed fadein");
        var tempColor = t.color;
        tempColor.a = 0.0f;

        t.color = tempColor;
        tempColor = t.color;
        tempColor.a = 0.0f;
        StartCoroutine(fadeinienum(t));

    }

    IEnumerator fadeinienum(Graphic t)
    {
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

    void fadeout(Graphic t)
    {
        //Debug.Log("passed fadein");
        var tempColor = t.color;
        tempColor.a = 1.0f;

        t.color = tempColor;
        tempColor = t.color;
        tempColor.a = 1.0f;
        StartCoroutine(fadeoutienum(t));

    }

    IEnumerator fadeoutienum(Graphic t)
    {
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
}
