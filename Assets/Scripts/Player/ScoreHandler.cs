using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    //variable to store score
    public int score; // stores player's score
    public TMP_Text scoreText; //textmesh score text, drag score to "Score text" tab

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore(int points)
    {
        score += points;
        scoreText.text = "Score : " + score;
    }
}
