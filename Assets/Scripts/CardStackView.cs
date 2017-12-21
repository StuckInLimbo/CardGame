using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code used from Sloan Kelly's tut series on card games, credit to him
[RequireComponent(typeof(CardStack))]
public class CardStackView : MonoBehaviour
{
    public Vector3 startPos;
    public float cardOffset;
    public GameObject cardPrefab;

    List<int> fetchedCards;
    CardStack deck;
    int lastCount;

    private void Start()
    {
        deck = GetComponent<CardStack>();
        fetchedCards = new List<int>();
        ShowCards();
        lastCount = deck.cardCount;
    }

    private void Update()
    {
        if(lastCount != deck.cardCount)
        {
            lastCount = deck.cardCount;
            ShowCards();
        }
    }

    private void ShowCards()
    {
        int cardCount = 0;
        if (deck.HasCards)
        {
            foreach (int i in deck.GetCards())
            {
                float cOffset = cardOffset * cardCount;
                Vector3 temp = startPos + new Vector3(cOffset, 0f);
                AddCard(temp, i, cardCount);

                cardCount++;
            }
        }
    }

    private void AddCard(Vector3 position, int cardIndex, int positionalIndex)
    {

        if(fetchedCards.Contains(cardIndex))
        {
            return;
        }
        GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
        cardCopy.transform.position = position;

        CardModel cModel = cardCopy.GetComponent<CardModel>();
        cModel.cardIndex = cardIndex;
        cModel.toggleFace(true);

        SpriteRenderer spRenderer = cardCopy.GetComponent<SpriteRenderer>();
        spRenderer.sortingOrder = positionalIndex;

        fetchedCards.Add(cardIndex);
    }
}
