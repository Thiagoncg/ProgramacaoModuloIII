using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{
    [SerializeField]
    private Transform car;
    void Update()
    {
        LookatTarget();
    }
    private void LookatTarget()
    {
        transform.LookAt(car);
    }
}
