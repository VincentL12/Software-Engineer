using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavey : MonoBehaviour
{
    public GameObject enemyprefabs;
    public float spawnTimes = 2;
    private float timers;
    // Start is called before the first frame update
    void Start()
    {
        timers = spawnTimes;

    }
    // Update is called once per frame
    void Update()
    {
        timers -= Time.deltaTime;

        if (timers < 0)
        {
            spawnenemys();
        }
    }

    void spawnenemys()
    {
        Instantiate(enemyprefabs, transform.position, Quaternion.identity);
        timers = spawnTimes;
    }
}