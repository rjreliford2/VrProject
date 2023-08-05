using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
    //controlls the zombie's behavior
{
    public GameObject zombie;
    public bool nearPlayer;
    public bool hit;
    public float moveSpeed;
    public float timeToKill;
    //timeToKill is the time it takes for a zombie to despawn, so that the animation can play
    GameObject player;
    float killTime;
    //time since zombie was shot

    // Start is called before the first frame update
    void Start()
    {
        nearPlayer = false;
        hit = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    //keeps track of distance to player for purpose of playing attack animation
    //if the zombie has not been hit it will run the movement method, otherwise
    //the killtime begins to tick upwards allowing the falling animation to play and the
    //zombie to be removed after so many seconds
    void Update()
    {
        if (!hit)
        {
            moveTowardsPlayer();
        }
        else
        {
            killTime += Time.deltaTime;
            if (timeToKill <= killTime)
            {
                Destroy(zombie);
            }
        }
        if (Vector3.Distance(transform.position, player.transform.position) < 1.5f)
        {
            nearPlayer = true;
        }
        else
        {
            nearPlayer = false;
        }
    }

    void moveTowardsPlayer()
        //makes zombie face the player and move towards them
    {
        transform.LookAt(player.transform);

        if (Vector3.Distance(transform.position, player.transform.position) > 0f)
        {

            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
        //keeps track of when a bullet hits the zombie in order to change the current hit bool
        //and calls scorekeeper component to add to the players score
    {
        if (other.CompareTag("Bullet"))
        {
            hit = true;
            player.GetComponent<ScoreKeeper>().AddScore();
        }
    }
}
