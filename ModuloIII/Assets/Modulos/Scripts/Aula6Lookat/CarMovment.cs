using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovment : MonoBehaviour
{    
    private float speed = 2.0f;
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
