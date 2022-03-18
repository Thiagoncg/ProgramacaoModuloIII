using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        MovePlayerController();
    }
    private void MovePlayerController()
    {
        float moveVertical = Input.GetAxis ("Vertical");
        float moveHorizontal = Input.GetAxis ("Horizontal");

         Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
         rb.AddForce(movement * speed);
    }
}
