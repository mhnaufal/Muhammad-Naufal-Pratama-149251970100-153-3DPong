using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle4 : MonoBehaviour
{
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }
}
