using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpHight;

    private bool isColliding = false;
    private Vector3 Velocity;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Velocity.x = Input.GetAxisRaw("Horizontal");
        Velocity.z = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpHight);
        }
        transform.position += Velocity * speed * Time.deltaTime;
    }
}
