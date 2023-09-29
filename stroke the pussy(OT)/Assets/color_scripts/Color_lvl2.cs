using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color_lvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textComponent;
    private string[] catParts = { "tail", "face", "paws", "body", "legs" };
    private string[] CatPart = { "tail", "face", "paws", "body", "legs" };
    void Start()
    {
 
        int randomIndex = Random.Range(0, catParts.Length);

        string question = "What is the color of " + catParts[randomIndex] + "," + CatPart[randomIndex] + "?";

   
        textComponent.text = question;
    }
}
