using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsLoad : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Your Score Is ! = " + (PlayerPrefs.GetInt("scorePlayer")));
    }

}
