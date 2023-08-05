using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour
{
    public GameObject player;
    int ammo;
    public Text ammoText;
    Shoot gun;
    // Start is called before the first frame update
    void Start()
    {
        gun = player.GetComponent<Shoot>();
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = "Ammo: " + gun.currentAmmo;
    }
}
