using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody2D rb;
    public Vector2 movement;
    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    private void moveCharacter(Vector2 direction)
    {
        rb.velocity = direction * speed;
    }
}