using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code used from Sloan Kelly's tut series on card games, credit to him
public class CardStack : MonoBehaviour
{
    private List<int> cards;

    public bool isGameDeck;

    public int cardCount
    {
        get
        {
            if (cards == null)
            {
                return 0;
            }
            else
            {
                return cards.Count;
            }
        }
    }

    public bool HasCards
    {
        get { return cards != null && cards.Count > 0; }
    }

    void Start()
    {
        cards = new List<int>();
        if (isGameDeck)
        {
            CreateDeck();
        }
    }

    public IEnumerable<int> GetCards()
    {
        foreach (int i in cards)
        {
            yield return i;
        }
    }
    
    public int Pop()
    {
        int temp = cards[0];
        cards.RemoveAt(0);
        return temp;
    }

    public void Push(int card)
    {
        cards.Add(card);
    }

    public void CreateDeck()
    {
        cards.Clear();

        for (int i = 0; i < 15; i++)
        {
            cards.Add(i);
        }

        int n = cards.Count; //Start at back of array, work forward
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            int temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }


}
