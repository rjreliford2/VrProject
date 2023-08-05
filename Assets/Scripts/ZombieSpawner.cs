using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    //level is for dictating the difficulty of the game, 
    //zombie is the gameobject which will be the zombie prefab which will be used to spwan the zombie
    //spawntimer will be how quickly zombies will spawn, level_start is for telling the game when the level begins and to start spawning
    //zombie_count is for telling the spawner to stop spawning zombies
    //spawnspot will be used to dictate which of the four locations the zombie will come from
    public int level = 1;
    public GameObject zombie;
    public float spawntimer = 0.0f;
    public float waitTime = 10.0f;
    public bool level_start;
    public int zombie_count = 0;
    public int zombie_max = 5;
    private int spawnspot;
    public GameObject wavedisplay;
    // Start is called before the first frame update
    void Start()
    {
        level_start = true;
        spawnspot = Random.Range(1,5);
        wavedisplay.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //will check to see if level start is true if yes will run and start spwawning zombies
        //according to the level if it's level one the zombie will spawn every 10 seconds
        //if other levels they will spawn at a rate of the weighttime - level and the zombie max will increase by zmobie max + (level * 2)
        //after spawning up to the zombiemax they will than look to see if there is any
        //zombie gameobjects left once they are all killed the game will end the level and prepare
        //to start next wave
        spawntimer += Time.deltaTime;
        if(level_start == true)
        {
            if(level == 1)
            {
                if(spawntimer > waitTime && zombie_count < zombie_max) 
                {
                    zombie_count += 1;
                    if(spawnspot == 1){
                        Vector3 spawn = new Vector3(-23,2,0);
                        Instantiate(zombie, spawn, Quaternion.identity);
                        spawntimer = spawntimer - waitTime;
                        spawnspot = Random.Range(1,5);
                    }
                     if(spawnspot == 2){
                        Vector3 spawn = new Vector3(29,2,0);
                        Instantiate(zombie, spawn, Quaternion.identity);
                        spawntimer = spawntimer - waitTime;
                        spawnspot = Random.Range(1,5);
                    }
                     if(spawnspot == 3){
                        Vector3 spawn = new Vector3(0,5,25);
                        Instantiate(zombie, spawn, Quaternion.identity);
                        spawntimer = spawntimer - waitTime;
                        spawnspot = Random.Range(1,5);
                    }
                     if(spawnspot == 4){
                        Vector3 spawn = new Vector3(0,1,-25);
                        Instantiate(zombie, spawn, Quaternion.identity);
                        spawntimer = spawntimer - waitTime;
                        spawnspot = Random.Range(1,5);
                    }
                }
                
                else
                {
                    if(zombie_count>= zombie_max)
                    {
                        wavedisplay.SetActive(true);
                        level += 1;
                        zombie_count = 0;
                        zombie_max++;

                    }
                }
            }
            else
            {
                if(spawntimer > (waitTime - level) && zombie_count < zombie_max)
                {
                    if(spawnspot == 1){
                        Vector3 spawn = new Vector3(-23,2,0);
                        Instantiate(zombie, spawn, Quaternion.identity);
                        spawntimer = spawntimer - (waitTime - level);
                    }
                     if(spawnspot == 2){
                        Vector3 spawn = new Vector3(29,2,0);
                        Instantiate(zombie, spawn, Quaternion.identity);
                        spawntimer = spawntimer - (waitTime - level);
                    }
                     if(spawnspot == 3){
                        Vector3 spawn = new Vector3(0,5,25);
                        Instantiate(zombie, spawn, Quaternion.identity);
                        spawntimer = spawntimer - (waitTime - level);
                    }
                     if(spawnspot == 4){
                        Vector3 spawn = new Vector3(0,1,-25);
                        Instantiate(zombie, spawn, Quaternion.identity);
                        spawntimer = spawntimer - (waitTime - level);
                    }
                    if(zombie_count >= (zombie_max + (level * 2)))
                    {
                        spawntimer = 0;
                    }
                    else
                    {
                        zombie_count += 1;
                    }
                }
                else
                {
                    if(zombie_count >= zombie_max)
                    {
                        wavedisplay.SetActive(true);
                        level += 1;
                        zombie_count = 0;
                        zombie_max++;
                    }
                }
            }
            
        }
    }
}
