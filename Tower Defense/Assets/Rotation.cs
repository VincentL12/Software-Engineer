using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
 
    [Header("Is your character facing right before runtime? If yes, check box")]
    public bool facingRight;
    public float horizontalValue;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        properFlip();
    }

    void move()
    {
        horizontalValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }

    void properFlip()
    {
        if ((horizontalValue < 0 && facingRight) || (horizontalValue > 0 && !facingRight))
        {
            facingRight = !facingRight;
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }
}
