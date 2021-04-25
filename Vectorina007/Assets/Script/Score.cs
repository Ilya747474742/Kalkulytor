using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Scores = 0;
    public Text Score0;
    public Button Strelka;

    public void Click()
    {
        Scores += 1;
        Score0.GetComponent<Text>().text = Scores.ToString();


    }
     void Update()
    {
        if (Scores >= 4)
        {
            Strelka.interactable = true;
        }
        else
        {
            Strelka.interactable = false;
        }
    }


}
