using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(speed, 0, speed), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
