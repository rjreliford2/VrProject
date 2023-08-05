using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //bullet prefab
    public GameObject bullet;

    //firerate will controll the time between shots fired
    public float firerate;

    //baserate will let us change the firerate with powerups then default back to
    //original firerate
    public int baserate;

    //timesince will mark the time since the last shot fired
    public float timeSince;

    public GameObject hand;
    float curX;
    float curY;
    float curZ;
    public int ammoCap;
    public int currentAmmo;

    // Start is called before the first frame update
    void Start()
    {
        timeSince = 0;
        currentAmmo = ammoCap;
    }

    // Update is called once per frame
    void Update()
    {
        timeSince += Time.deltaTime;
        if(firerate <= timeSince)
        {
            if (Input.GetKey(KeyCode.E) && currentAmmo > 0)
            {
                curX = this.transform.position.x;
                curY = this.transform.position.y;
                curZ = this.transform.position.z;
                Instantiate(bullet, new Vector3(curX, curY, curZ), hand.transform.rotation);
                currentAmmo--;
                timeSince = 0;
            }
            if (Input.GetKey(KeyCode.R))
            {
                currentAmmo = ammoCap;
            }
        }
    }
}
