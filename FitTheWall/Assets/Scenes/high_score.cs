using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class high_score : MonoBehaviour
{
    public Text text;    

    void Start()
    {
        text.text = PlayerPrefs.GetInt("high_score").ToString();
    }

    public void updateScore()
    {
        PlayerPrefs.SetInt("high_score", PlayerPrefs.GetInt("high_score", 0) + 1);
        text.text = PlayerPrefs.GetInt("high_score").ToString();
    }

}
