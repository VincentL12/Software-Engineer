using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementL : MonoBehaviour

{
    public Rigidbody2D enemyl;
    public Animator animatorl;
    public float speedl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyl.velocity = Vector2.right * speedl;
        animatorl.SetBool("Walk", true);
    }
}
