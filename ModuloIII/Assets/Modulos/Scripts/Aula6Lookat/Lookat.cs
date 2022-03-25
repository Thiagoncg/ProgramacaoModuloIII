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
        DeleteObject();
    }
    private void LookatTarget()
    {
        transform.LookAt(car);
    }

    private void DeleteObject()
    {
        RaycastHit carCollider;

        if (Physics.Raycast(transform.position, transform.forward, out carCollider, 10))       
        {
            if(carCollider.transform.gameObject.activeSelf)
            {
                carCollider.transform.gameObject.SetActive(false);
            }  
        }

    }
}
