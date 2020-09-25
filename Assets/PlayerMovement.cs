using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 10f;

    public Rigidbody2D rb;

    Vector2 Movement;


    // Update is called once per frame
    void Update() // input
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() // movement
    {
        rb.MovePosition(rb.position + Movement * MovementSpeed * Time.fixedDeltaTime);
    }
}
