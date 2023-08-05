using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
    //script disables components to end the game
{
    public GameObject gameOverScreen;
    public GameObject player;
    public GameObject spawner;
    public GameObject waveDisplay;
    private void OnTriggerEnter(Collider other)
    {
        //once the player comes into contact with a zombie they lose their movement
        //the spawner is turned off to prevent additional zombie spawns
        //the game over ui is set to active
        if (other.CompareTag("Zombie")) 
        { 
            player.GetComponent<SimplePlayerMovement>().enabled= false;
            spawner.SetActive(false);
            gameOverScreen.SetActive(true);
            waveDisplay.SetActive(false);
            player.GetComponent<AudioSource>().enabled= false;
        }
    }
}

