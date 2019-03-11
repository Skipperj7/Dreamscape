using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class dad : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Sprite> dadsprites;
    public bool breathing;
    public GameObject player;
    void Start()
    {
        StartCoroutine(breathe());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int i = 0;
    IEnumerator breathe() {
        if(i > 3) {
            i = 0;
        }
        if (breathing) {

           gameObject.GetComponent<SpriteRenderer>().sprite = dadsprites[i];
            yield return new WaitForSeconds(.4f);
            i++;
            StartCoroutine(breathe());
        }
            else {
                yield return null;
            }
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = dadsprites[0];
            breathing = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            breathing = true;
            StartCoroutine(breathe());
        }
    }
}
