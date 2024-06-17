using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Buff : MonoBehaviour
{
    public GameObject buff;
    public void attack()
    {
        Time.timeScale = 1f;
        HeroKnight.attackDamage += 5;
        buff.SetActive(false);
    }

    public void speed()
    {
        Time.timeScale = 1f;
        HeroKnight.m_speed += 0.5f;
        buff.SetActive(false);  
    }

    public void heal()
    {
        Time.timeScale = 1f;
        TowerHealth.heal = 100;
        buff.SetActive(false);
    }
}
