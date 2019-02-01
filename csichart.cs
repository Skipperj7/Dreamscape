using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class csichart : MonoBehaviour
{

    public List<SpriteRenderer> boxes;
    public List<string> answers;
    public List<string> correctanswers;
    public int numcorrect;
    public int totalnum;

    public Sprite check;
    public Sprite blank;
    public Sprite x;

    public Button submitbtn;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        submitbtn.onClick.AddListener(checkanswers);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkanswers() { 
        foreach(SpriteRenderer s in boxes) {
            if (s.sprite == check)
            {
                answers.Add("check");
            }
            else if (s.sprite == x)
            {
                answers.Add("x");
            }
            else if (s.sprite == blank)
            {
                answers.Add("blank");
            }
            
        }

        for(int i = 0; i < totalnum;i++) {
            Debug.Log(i);
            if(answers[i] == correctanswers[i]) { 
            numcorrect++;
            }
        }

        float percent = (100 * numcorrect) / (totalnum);
        score.text = percent + "%";
    }

}
