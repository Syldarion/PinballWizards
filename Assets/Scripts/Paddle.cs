using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed;
    public bool isEngaged;
    public Rigidbody2D paddleRigidbody;

    public Vector3 forcePoint;

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position + forcePoint, 0.1f);
    }

    private void FixedUpdate()
    {
        if (isEngaged)
        {
            paddleRigidbody.AddForceAtPosition(Vector2.up * paddleSpeed,
                                               transform.position + forcePoint,
                                               ForceMode2D.Force);
        }
        else
        {
            paddleRigidbody.AddForceAtPosition(-Vector2.up * paddleSpeed,
                                               transform.position + forcePoint,
                                               ForceMode2D.Force);
        }
    }

    public void Flip()
    {
        isEngaged = true;
    }

    public void Reset()
    {
        isEngaged = false;
    }
}
