using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int score;
    Text scoreUI;
    void Start()
    {
       score= CountTrigger.counter;
        scoreUI = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = CountTrigger.counter;
        scoreUI.text = "Cheese = "+ score;
    }
}
