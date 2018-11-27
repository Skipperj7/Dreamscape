using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{

    public Image hair;
    public Image shirt;
    public Image pants;
    public Image shoes;

    public Button hairright;
    public Button hairleft;
    public Button shirtright;
    public Button shirtleft;
    public Button pantsright;
    public Button pantsleft;
    public Button shoesright;
    public Button shoesleft;


    public BackgroundMechanics script;
    public data script1;

    private List<string> hairlist;
    private List<string> shirtlist;
    private List<string> pantslist;
    private List<string> shoeslist;

    private List<string> hairlistunlocked;
    private List<string> shirtlistunlocked;
    private List<string> pantslistunlocked;
    private List<string> shoeslistunlocked;

    private int hairselected;
    private int shirtselected;
    private int pantsselected;
    private int shoesselected;

    // Use this for initialization
    void Start()
    {
        hair.sprite = script1.hair;
        shirt.sprite = script1.shirt;
        pants.sprite = script1.pants;
        shoes.sprite = script1.shoes;

        hairright.onClick.AddListener(hairrightfunc);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void hairrightfunc(){
        spinthrough(hair, 1);
    }
    void hairleftfunc()
    {
        spinthrough(hair, -1);
    }
    void shirtrightfunc()
    {
        spinthrough(shirt, 1);
    }
    void shirtleftfunc()
    {
        spinthrough(shirt, -1);
    }
    void pantsrightfunc()
    {
        spinthrough(pants, 1);
    }
    void pantsleftfunc()
    {
        spinthrough(pants, -1);
    }
    void shoesrightfunc()
    {
        spinthrough(shoes, 1);
    }
    void shoesleftfunc()
    {
        spinthrough(shoes, -1);
    }


	void spinthrough(Image img, int i){
        switch
	}

	void findunlocked(Image img){
		//compare locked to unlocked to see if item is unlocked
	}

    void findsprite(){
        
    }

    void equip(Image img, Sprite s){
        
    }

	//access backgroundmechanics data to save unlocked
}
