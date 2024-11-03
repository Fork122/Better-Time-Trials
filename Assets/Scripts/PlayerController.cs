using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpHight;
    [SerializeField]
    private float gravityScale = 5f;
    [SerializeField]
    private float fallGravityScale = 15f;
    [SerializeField]
    private float buttonPressedTimeWindow = 1f;
    private float buttonPressedTime;
    private bool jumping;

    private Vector3 velocity;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.z = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = gravityScale;
            jumping = true;
        }
        if (jumping)
        {
            buttonPressedTime += Time.deltaTime;
            rb.velocity = new Vector2(rb.velocity.x, jumpHight);

            if (buttonPressedTime > buttonPressedTimeWindow || Input.GetKeyUp(KeyCode.Space))
            {
                jumping = false;
            }
        }
        transform.position += velocity * speed * Time.deltaTime;
    }
}
