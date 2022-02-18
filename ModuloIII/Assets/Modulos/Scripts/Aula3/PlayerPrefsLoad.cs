using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsLoad : MonoBehaviour
{


    //----------PUBLIC COMPONENTS---------
    public Text TextScore;
    public Text TextName;

    private int score;


    void Start()
    { 
        TextScore.text = PlayerPrefs.GetInt("scorePlayer").ToString();


        TextName.text = PlayerPrefs.GetString("myName");
    }

}
