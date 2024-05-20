using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Buff : MonoBehaviour
{
    public GameObject buff;
    public void attack()
    {
        HeroKnight.attackDamage += 5;
        buff.SetActive(false);
    }

    public void speed()
    {
        HeroKnight.m_speed += 0.5f;
        buff.SetActive(false);  
    }

    public void heal()
    {
        TowerHealth.heal = 20;
        buff.SetActive(false);
    }
}
