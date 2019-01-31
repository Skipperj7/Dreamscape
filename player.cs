using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    public float speed;
    public SpriteRenderer playersprite;
    public List<Sprite> rightsprites;
    public bool r;
    private bool rrunning;
    public List<Sprite> leftsprites;
    public bool l;
    private bool lrunning;
    public List<Sprite> upsprites;
    public bool u;
    private bool urunning;
    public List<Sprite> downsprites;
    public bool d;
    private bool drunning;

    private int rint = 0;
    private int lint = 0;
    private int upint = 0;
    private int dint = 0;


    public Rigidbody2D rigid;
    void Start()
    {
        // Freeze the rotation
        rigid.freezeRotation = true;
    }
    void Update()
    {
        //Debug.Log(rigid.velocity);
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector2.right * speed * Time.deltaTime);
            rigid.AddForce(Vector2.right * speed);

            if (!lrunning & !rrunning & !urunning & !drunning)
            {
                StartCoroutine(rightwalkanimation(rint));
            }
            r = true;

        }
        else
        {
            r = false;

        }


        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector2.left * speed * Time.deltaTime);
            rigid.AddForce(Vector2.left * speed);
            if (!lrunning & !rrunning & !urunning & !drunning)
            {
                StartCoroutine(leftwalkanimation(lint));
            }
            l = true;

        }
        else
        {
            l = false;

        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector2.up * speed * Time.deltaTime);
            rigid.AddForce(Vector2.up * speed);
            if (!lrunning & !rrunning & !urunning & !drunning)
            {
                StartCoroutine(upwalkanimation(upint));
            }
            u = true;
            rigid.velocity = Vector2.zero;
        }
        else
        {
            u = false;

        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector2.down * speed * Time.deltaTime);
            rigid.AddForce(Vector2.down * speed);
            if (!lrunning & !rrunning & !urunning & !drunning)
            {
                StartCoroutine(downwalkanimation(dint));
            }
            d = true;

        }
        else
        {
            d = false;

        }

        rigid.velocity = Vector2.zero;


    }

    //Coroutine rw = StartCoroutine(rightwalkanimation());


    public IEnumerator rightwalkanimation(int i)
    {
        rrunning = true;
        if (i > 6)
        {
            i = 0;
            rint = 0;
        }
        yield return new WaitForSeconds(.1f);
        playersprite.sprite = rightsprites[i];
        rint = rint + 1;
        rrunning = false;
        if (r & !rrunning)
        {
            StartCoroutine(rightwalkanimation(rint));

        }
        else
        {
            yield return new WaitForSeconds(.1f);
            playersprite.sprite = rightsprites[0];
        }
    }


    IEnumerator leftwalkanimation(int i)
    {
        lrunning = true;
        if (i > 6)
        {
            i = 0;
            lint = 0;
        }
        yield return new WaitForSeconds(.1f);
        playersprite.sprite = leftsprites[i];
        lint = lint + 1;
        lrunning = false;
        if (l & !lrunning)
        {
            StartCoroutine(leftwalkanimation(lint));
        }
        else
        {
            yield return new WaitForSeconds(.1f);
            playersprite.sprite = leftsprites[0];
        }
    }
    IEnumerator upwalkanimation(int i)
    {
        urunning = true;
        if (i > 6)
        {
            i = 0;
            upint = 0;
        }
        yield return new WaitForSeconds(.1f);
        playersprite.sprite = upsprites[i];
        upint = upint + 1;
        urunning = false;
        if (u & !urunning)
        {
            StartCoroutine(upwalkanimation(upint));

        }
        else
        {
            yield return new WaitForSeconds(.1f);
            playersprite.sprite = upsprites[0];
        }
    }
    IEnumerator downwalkanimation(int i)
    {
        drunning = true;
        if (i > 6)
        {
            i = 0;
            dint = 0;
        }
        yield return new WaitForSeconds(.1f);
        playersprite.sprite = downsprites[i];
        dint = dint + 1;
        drunning = false;
        if (d & !drunning)
        {
            StartCoroutine(downwalkanimation(dint));

        }
        else
        {
            yield return new WaitForSeconds(.1f);
            playersprite.sprite = downsprites[0];
        }
    }
}