using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    static public int maxHealth = 100;
    public int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if(currentHealth <= 10){
            Die();
        }
    }
    void Die()
    {
        Score.exp += 1;
        Score.scoreValue += 10;
        Wave.onEnemyDestroy.Invoke();
        animator.SetBool("Dead",true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        FindObjectOfType<AudioManager>().Play("Hurt");
        Destroy(gameObject);
    }
}
