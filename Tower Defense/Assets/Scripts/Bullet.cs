using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null) 
        {
            enemy.TakeDamage(HeroKnight.attackDamage*2);
            Destroy(gameObject);
        }
       
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer > 0.5)
        {
            Destroy(gameObject);
        }
    }
}
