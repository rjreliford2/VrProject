using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wavedisplay : MonoBehaviour
{
    public Text waveText;
    public GameObject spawner;
    private int wavelevel;
    // Start is called before the first frame update
    void Start()
    {
        wavelevel = spawner.GetComponent<ZombieSpawner>().level;
        waveText.text = "Wave " + wavelevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        wavelevel = spawner.GetComponent<ZombieSpawner>().level;
        waveText.text = "Wave " + wavelevel.ToString();
    }
}
