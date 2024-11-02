using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpHight;

    private Vector3 Velocity;

    // Update is called once per frame
    void Update()
    {
        Velocity.x = Input.GetAxisRaw("Horizontal");
        Velocity.z = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
        else
        {
             Velocity.y = 0;
        }
        transform.position += Velocity * speed * Time.deltaTime;
    }
}
