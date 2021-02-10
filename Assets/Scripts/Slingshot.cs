using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public float slingshotForce;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position + transform.up, 0.5f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Slingshot hit", this.gameObject);
        other.attachedRigidbody.AddForce(transform.up * slingshotForce);
    }
}
