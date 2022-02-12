using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private GameObject lightSpot;
    void Start()
    {
        lightSpot.GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnActivateDesactivateLight()
    {

    }

    public void BtnEnableDesableLight()
    {
        if (lightSpot.GetComponent<Light>().enabled == false)
        {
            lightSpot.GetComponent<Light>().enabled = true;
        }
        else
        {
            lightSpot.GetComponent<Light>().enabled = false;
        }
        
    }

}
