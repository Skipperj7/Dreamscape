﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class backbutton : MonoBehaviour
{

    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(clicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void clicked() {
        SceneManager.LoadScene(1);
    }
}
