using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public Character character;
    void Start()
    {
        character = new Character();

        BtnSaveCharacter();
        // BtnLoadCharacter();
    }

    public void BtnSaveCharacter()
    {
        character.CharacterName = "Arqueiro Fantasm";
        character.CharacterSpeed = 150.0f;
        character.CharaterPower = 2500;
        character.Characterskills = new string[] {"Super Pulo", "Lança Chamas","Efeito Fantasma"};
        
        character.SaveCharacter();
    }

    public void BtnLoadCharacter()
    {
        character.LoadCharacter();
    }


    /*conversores
    De String para Float
    Float.Parse("Name.text");

    De String Para Inteiro
    Int.Parse("Name.text");

    De Inteiro para String
    Idade.text = idade.ToString();

    character.CharacterSpeed = float.Parse(InputCharacterSpeed.text);
    character.CharaterPower = int.Parse(InputCharacterPower.text);


    */

}
