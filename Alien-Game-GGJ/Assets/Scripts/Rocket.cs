using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    public Rigidbody2D rb;

    public float speed = 10f;
    public float verticle;
    public float horizontal;
    public float rotateSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
 

        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0f, 0f, rotateSpeed));
        }
        else if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0f,0f, -rotateSpeed));

        }

        rb.velocity = transform.up * speed;
        
    }
}
