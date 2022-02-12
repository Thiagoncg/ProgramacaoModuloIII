using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    void Start()
    {
        cube.SetActive(true);
        cube.GetComponent<MeshRenderer>().enabled = true;
        Debug.Log("Status = " + cube.activeSelf);
        cube.GetComponent<BoxCollider>().enabled = true;
    }

//botão mesh render
    public void BtnEnabeDesableMeshRender()
    {
        if(cube.GetComponent<MeshRenderer>().enabled == false)
        {
            cube.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            cube.GetComponent<MeshRenderer>().enabled = false;
        }
    }

//botão active render
    public void BtnActivateDesactivate()
    {
        if (cube.activeSelf)
        {
            cube.SetActive(false);
        }
        else
        {
            cube.SetActive(true);
        }
    }

//botão box collider
    public void BtnActiveBoxCollider()
    {
        if (cube.GetComponent<BoxCollider>().enabled == false)
        {
            cube.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            cube.GetComponent<BoxCollider>().enabled = false;

        }



    }
}
