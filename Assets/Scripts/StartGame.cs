using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
    //script that activates components once the game begins
{
    public GameObject player;
    SimplePlayerMovement movement;
    public GameObject startScreen;
    public GameObject spawner;
    public GameObject waveDisplay;
    AudioSource playerSteps;
    // Start is called before the first frame update
    void Start()
        //gets the playermovment in order to start it later
    {
        movement = player.GetComponent<SimplePlayerMovement>();
        playerSteps = player.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
        //once the player hits e to start the game update enables movement
        //removes the start screen ui and turns the zombie spawner on
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            movement.enabled = true;
            startScreen.SetActive(false);
            spawner.SetActive(true);
            waveDisplay.SetActive(true);
            playerSteps.enabled= true;
        }

    }
}
