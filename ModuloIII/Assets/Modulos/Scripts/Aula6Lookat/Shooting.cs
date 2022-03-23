using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;
    void Update()
    {
        ClickShooting();
    }
    private void ClickShooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
