using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 300f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Bullet();
    }
    private void Bullet()
    {
        rb.AddForce(transform.forward * speed);
    }
}
