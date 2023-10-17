using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerColorLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManagerColorLevel Instance;

    public List<string> catParts = new() { "arm","tail", "face", "paws", "legs", "body" };
    public List<string> catColors = new() { "Red", "Blue", "Green", "Purple", "Brown", "Yellow" };

    public Dictionary<string, Sprite> selectedColParts;

    public List<Sprite> arm, body, paws, face, ears, tail;
    List<List<Sprite>> partsList;
         
    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        Instance = this;
        if (FindObjectsOfType<GameManagerColorLevel>().Length > 1)
        {
            partsList = new() { arm, body, paws, face, ears, tail };
            Destroy(this.gameObject);

        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

        partsList = new() {arm, body, paws, face, ears, tail };

        //catParts.AddRange(new List<string> { "Tail", "Face", "Paws", "Legs", "Body" });
        //catColors.AddRange(new List<string>() { "Red", "Blue", "Green", "Purple", "Brown", "Yellow" });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initLevel()
    {
        string currLevelName = SceneManager.GetActiveScene().name;
    }

    public void ChangeScene(string name)
    {
        switch (name)
        {
            case "Color_level1":
                List<Sprite> part = partsList[Random.Range(0, partsList.Count)];
                Sprite selectedCol = part[Random.Range(1, part.Count)];
                selectedColParts[part[0].name] = selectedCol;
                break;
            case "Color_level2":
                for(int i = 0; i < 2; i++)
                {
                    part = partsList[Random.Range(0, partsList.Count)];
                    selectedCol = part[Random.Range(1, part.Count)];
                    selectedColParts[part[0].name] = selectedCol;
                    partsList.Remove(part);
                }
                break;
            case "Color_level3":
                for (int i = 0; i < 3; i++)
                {
                    part = partsList[Random.Range(0, partsList.Count)];
                    selectedCol = part[Random.Range(1, part.Count)];
                    selectedColParts[part[0].name] = selectedCol;
                    partsList.Remove(part);
                }
                break;
            case "Color_level4":
                for (int i = 0; i < 4; i++)
                {
                    part = partsList[Random.Range(0, partsList.Count)];
                    selectedCol = part[Random.Range(1, part.Count)];
                    selectedColParts[part[0].name] = selectedCol;
                    partsList.Remove(part);
                }
                break;
            case "Color_level5":
                for (int i = 0; i < 5; i++)
                {
                    part = partsList[Random.Range(0, partsList.Count)];
                    selectedCol = part[Random.Range(1, part.Count)];
                    selectedColParts[part[0].name] = selectedCol;
                    partsList.Remove(part);
                }
                break;
        }
        foreach(var key in selectedColParts.Keys)
        {
            Debug.Log(key);
        }
        SceneManager.LoadScene(name);
    }


}
