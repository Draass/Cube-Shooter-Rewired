using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Camera camera;

    [SerializeField] private float speed = 5f;

    private Vector2 movement;
    private Vector2 mousePosition;


    void Start()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        //was in Update before
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        if (movement.magnitude > 1.0f)
            movement.Normalize();

        Vector2 lookDirection = mousePosition - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;
    }
}
