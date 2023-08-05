using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
    //this script keeps track of the players score and has methods called
    //within other scripts to add or get the score
{
    public int score;
    // Start is called before the first frame update
    void Start()
        //sets score to zero
    {
        score= 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
        //called when a zombie collides with a bullet, adds to score by 1
    {
        score++;
    }
    
    public int GetFinalScore()
        //called when game ends, returns the current score for the ui to update
    {
        return score;
    }
}
