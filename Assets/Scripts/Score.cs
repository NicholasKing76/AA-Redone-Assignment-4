using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public Text text;
    public static int highscore = 0;

    void Start()
    {
        PinCount = 0;
    }

    void Update()
    {
        PlayerPrefs.SetInt("Score", PinCount);
        if (PinCount > highscore)
        {
            highscore = PinCount;
        }
        PlayerPrefs.SetInt("HighScore", highscore);
        text.text = PinCount.ToString();
    }
}
