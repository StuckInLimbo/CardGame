using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code used from Sloan Kelly's tut series on card games, credit to him
public class DebugChangeCard : MonoBehaviour
{
    public GameObject card;

    private CardModel cModel;
    private CardFlipper cFlipper;
    private int cardIndex = 0;

    void Awake()
    {
        cModel = card.GetComponent<CardModel>();
        cFlipper = card.GetComponent<CardFlipper>();
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 20),"Next card"))
        {
            if(cardIndex >= cModel.faces.Length)
            {
                cardIndex = 0;
                cFlipper.flipCard(cModel.faces[cModel.faces.Length-1], cModel.cardBack, -1);
                //cModel.toggleFace(false);
            }
            else
            {
                if (cardIndex > 0)
                {
                    cFlipper.flipCard(cModel.faces[cardIndex - 1], cModel.faces[cardIndex], cardIndex);
                }
                else
                {
                    cFlipper.flipCard(cModel.cardBack, cModel.faces[cardIndex], cardIndex);
                }
                //cModel.cardIndex = cardIndex;
                //cModel.toggleFace(true);
                cardIndex++;
            } 
        }
    }
}
