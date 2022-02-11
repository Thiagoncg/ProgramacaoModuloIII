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
    }

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
}
