using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimation : MonoBehaviour
    //script controlls the zombie animator based on their behavior script
{
    public Animator animator;
    public GameObject zombie;
    public EnemyBehavior behavior;
    // Start is called before the first frame update
    void Start()
        //gets the behavior of the spawned zombie
    {
        behavior = zombie.GetComponent<EnemyBehavior>();
    }

    // Update is called once per frame
    void Update()
        //changes the current animation to either attacking or dying
    {
        animator.SetBool("NearPlayer", behavior.nearPlayer);
        animator.SetBool("Hit", behavior.hit);
    }
}
