using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Security.Cryptography.X509Certificates;

public class TowerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 50;
    public Slider slider;
    public GameObject GameOver;
    public static int heal;
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
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        }

        if(heal == 100)
        {
            health += 100;
            heal = 0;
        }
    }
}
