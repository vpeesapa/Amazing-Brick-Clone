using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float gravity = 2.0f;

    [SerializeField] private float xForce = 1.5f;
    [SerializeField] private float yForce = 5.0f;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.gravityScale = gravity;
            rb.velocity = new Vector2(-xForce,yForce);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.gravityScale = gravity;
            rb.velocity = new Vector2(xForce,yForce);
        }
    }
}
