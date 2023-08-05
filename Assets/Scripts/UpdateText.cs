using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
    //script for updating the score at the end of the game for the ui
{
    public GameObject player;
    ScoreKeeper score;
    public Text text;
    // Start is called before the first frame update
    void Start()
        //gets the scorekeeper on the player
    {
        score = player.GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
        //changes the ui text to the value in the scorekeeper
    {
        text.text = score.GetFinalScore().ToString();
    }
}
