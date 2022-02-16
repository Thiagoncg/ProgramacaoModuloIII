using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerPrefsSet : MonoBehaviour
{

    private void Start()
    {
        Debug.Log("Your saved score is : " + (PlayerPrefs.GetInt("scorePlayer")));
    }

    public void BtnSavePlayerPrefs()
    {
        PlayerPrefs.SetInt("scorePlayer", 500);
        Debug.Log("Saved Score ! = " + (PlayerPrefs.GetInt("scorePlayer")));
    }
}
