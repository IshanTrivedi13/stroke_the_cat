using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_arm : MonoBehaviour
{
    [SerializeField] private Sprite red;
    [SerializeField] private Sprite yellow;
    [SerializeField] private Sprite green;
    [SerializeField] private Sprite blue;
    [SerializeField] private Sprite violet;
    [SerializeField] private Sprite brown;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        int rand = Random.Range(0,6);
        if (rand == 0)
        {
            spriteRenderer.sprite = red;
        }
        else if (rand == 1)
        {
            spriteRenderer.sprite = yellow;
        }
        else if (rand == 2)
        {
            spriteRenderer.sprite = green;
        }
        else if (rand == 3)
        {
            spriteRenderer.sprite = blue;
        }
        else if (rand == 4)
        {
            spriteRenderer.sprite = violet;
        }
        else if (rand == 5)
        {
            spriteRenderer.sprite = brown;
        }
    }

}
