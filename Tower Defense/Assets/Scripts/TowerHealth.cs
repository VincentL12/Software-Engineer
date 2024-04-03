using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 50;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        slider.maxValue = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
