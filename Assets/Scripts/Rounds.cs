﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rounds : MonoBehaviour
{
    public Text roundsText;
    public static int roundCount = 1;

    void Start()
    {
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        //PlayerPrefs.SetInt("rounds", roundCount);


    }
    void Update()
    {
        //roundCount = PlayerPrefs.GetInt("rounds");
        roundsText.text = "Round: " + roundCount;

    }
}
