using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code used from Sloan Kelly's tut series on card games, credit to him
public class CardModel : MonoBehaviour
{
    public Sprite[] faces;
    public Sprite cardBack;
    public int cardIndex; // for faces[cardIndex]

    private SpriteRenderer spRenderer;

    private void Awake()
    {
        spRenderer = GetComponent<SpriteRenderer>();
    }

    public void toggleFace(bool showFace)
    {
        if (showFace)
        {
            spRenderer.sprite = faces[cardIndex];
        }
        else
        {
            spRenderer.sprite = cardBack;
        }
    }
}
