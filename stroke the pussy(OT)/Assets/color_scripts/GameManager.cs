using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Define arrays as static to make them accessible from the Save method
    private static string[] catParts = { "Tail", "Face", "Paws", "Legs", "Body" };
    private static string[] catColors = { "Red", "Blue", "Green", "Purple", "Brown", "Yellow" };

    private string randomCatPart;
    private string randomCatColor;

    void Start()
    {
        // Initialize randomCatPart and randomCatColor here
        randomCatPart = catParts[Random.Range(0, catParts.Length)];
        randomCatColor = catColors[Random.Range(0, catColors.Length)];

        // Call the Save method if you want to save the values to PlayerPrefs
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetString("CatPart", randomCatPart);
        PlayerPrefs.SetString("CatColor", randomCatColor);
        PlayerPrefs.Save();
    }
}
