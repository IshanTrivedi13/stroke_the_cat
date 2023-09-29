using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class QuestionManager : MonoBehaviour
{
    public Text questionText;
    public List<Button> answerButtons;

    private string[] catParts = { "Tail", "Face", "Paws", "Legs", "Body" };

    private void Start()
    {
        // Get the selected level from PlayerPrefs
        int selectedLevel = PlayerPrefs.GetInt("SelectedLevel", 1);

        // Generate a random question based on the selected level
        string catPart = GetCatPart(selectedLevel);
        string question = "What is the color of " + catPart + "?";
        questionText.text = question;

        // Implement answer button logic here
    }

    private string GetCatPart(int level)
    {
        if (level < 1 || level > catParts.Length)
        {
            level = 1; // Default to level 1 if invalid level
        }
        return catParts[level - 1];
    }
}
