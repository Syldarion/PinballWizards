using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float bumpForce;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Vector2 forceDirection = (other.transform.position - this.transform.position).normalized;
        other.rigidbody.AddForce(forceDirection * bumpForce, ForceMode2D.Force);
    }
}
