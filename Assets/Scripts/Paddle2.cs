using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Paddle2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position + Vector3.right * (-speed) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + Vector3.right * (speed) * Time.deltaTime);
        }
    }
}
