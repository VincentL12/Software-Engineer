using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public GameObject enemyprefab;
    public float spawnTime = 2;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;

    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            spawnenemy();
        }
    }

    void spawnenemy()
    {
        Instantiate(enemyprefab, transform.position, Quaternion.identity);
        timer = spawnTime;
    }
}
