﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyUIManager : MonoBehaviour
{
    public Text hpText;
    public Text nameText;

    public void UpdateUI()
    {
        hpText.text = string.Format("HP: {0}", 80);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
