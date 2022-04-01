using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletController : MonoBehaviour
{
    public float speed;
    public float HorizontalAxis;
    public Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalAxis = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(speed * HorizontalAxis, 0);
    }
}
