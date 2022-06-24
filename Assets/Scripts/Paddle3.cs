using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle3 : MonoBehaviour
{
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }
}
