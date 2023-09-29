using UnityEngine;
using UnityEngine.UI;

public class RandomTextGenerator_Color : MonoBehaviour
{
    public Text textComponent;
    private string[] catParts = { "tail", "face", "paws", "body", "legs" };

    void Start()
    {

        int randomIndex = Random.Range(0, catParts.Length);

  
        string question = "What is the color of " + catParts[randomIndex] + "?";


        textComponent.text = question;
    }
}
