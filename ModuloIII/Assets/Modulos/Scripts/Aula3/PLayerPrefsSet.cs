using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLayerPrefsSet : MonoBehaviour
{

    //-----------PUBLIC COMPONENTS------------
    public InputField InputFieldName;

    private void Start()
    {
        Debug.Log("Your saved score is : " + (PlayerPrefs.GetInt("scorePlayer")));
    }

    public void BtnSavePlayerPrefs()
    {
        PlayerPrefs.SetInt("scorePlayer", 500);
        PlayerPrefs.SetFloat("Position", 150.00f);
        PlayerPrefs.SetString("myName", InputFieldName.text);

        Debug.Log("Saved Score ! = " + (PlayerPrefs.GetInt("scorePlayer")));
        Debug.Log("Saved Name: " + PlayerPrefs.GetString("myName"));
    }
}
