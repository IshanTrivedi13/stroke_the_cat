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
        if (catPart == "Tail")
        {
            if (ColorTail.rand == 0)
                //correct answer is red
                ;
            else if(ColorTail.rand == 1)
                //correct answer is yellow
                ;
            else if(ColorTail.rand == 2)
                //correct answer is green
                ;
            else if(ColorTail.rand == 3)
                //correct answer is blue
                ;
            else if(ColorTail.rand == 4)
                //correct answer is purple
                ;
            else 
                //correct answer is brown
                ;
        }
        else if (catPart == "Face")
        {
            if (ColorFace.rand == 0)
                //correct answer is red
                ;
            else if(ColorFace.rand == 1)
                //correct answer is yellow
                ;
            else if(ColorFace.rand == 2)
                //correct answer is green
                ;
            else if(ColorFace.rand == 3)
                //correct answer is blue
                ;
            else if(ColorFace.rand == 4)
                //correct answer is purple
                ;
            else 
                //correct answer is brown
                ;
        }
        else if (catPart == "Body")
        {
            if (ColorBody.rand == 0)
                //correct answer is red
                ;
            else if(ColorBody.rand == 1)
                //correct answer is yellow
                ;
            else if(ColorBody.rand == 2)
                //correct answer is green
                ;
            else if(ColorBody.rand == 3)
                //correct answer is blue
                ;
            else if(ColorBody.rand == 4)
                //correct answer is purple
                ;
            else 
                //correct answer is brown
                ;
        }
        else if (catPart == "Legs")
        {
            if (ColorArm.rand == 0)
                //correct answer is red
                ;
            else if(ColorArm.rand == 1)
                //correct answer is yellow
                ;
            else if(ColorArm.rand == 2)
                //correct answer is green
                ;
            else if(ColorArm.rand == 3)
                //correct answer is blue
                ;
            else if(ColorArm.rand == 4)
                //correct answer is purple
                ;
            else 
                //correct answer is brown
                ;
        }
        else if (catPart == "Paws")
        {
            if (ColorPaws.rand == 0)
                //correct answer is red
                ;
            else if(ColorPaws.rand == 1)
                //correct answer is yellow
                ;
            else if(ColorPaws.rand == 2)
                //correct answer is green
                ;
            else if(ColorPaws.rand == 3)
                //correct answer is blue
                ;
            else if(ColorPaws.rand == 4)
                //correct answer is purple
                ;
            else 
                //correct answer is brown
                ;
        }
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
