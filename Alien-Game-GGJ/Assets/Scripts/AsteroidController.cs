using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float maxMoveSpeed;
    public float maxRotationSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-maxMoveSpeed, maxMoveSpeed), Random.Range(-maxMoveSpeed, maxMoveSpeed));
        rb.angularVelocity = Random.Range(-maxRotationSpeed, maxRotationSpeed) * 10;
    }
}
