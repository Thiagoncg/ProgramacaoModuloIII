using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class Character
{
    public string CharacterName;
    public float CharacterSpeed;
    public int CharaterPower;
    public string[] Characterskills;
  
    private string path = "Assets/Character.json";


    public void SaveCharacter()
    {
        var content = JsonUtility.ToJson(this, true);
        File.WriteAllText(path, content);
    }

    public void LoadCharacter()
    {
        var content = File.ReadAllText(path);
        var c = JsonUtility.FromJson<Character>(content);

        CharacterName = c.CharacterName;
        CharacterSpeed = c.CharacterSpeed;
        CharaterPower = c.CharaterPower;
        Characterskills = c.Characterskills;
    }


}
