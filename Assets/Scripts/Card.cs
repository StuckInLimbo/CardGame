using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public int cardSuit;
    public int cardValue;

    private enum CardSuit { Spades, Hearts, Diamonds, Clubs };
    private enum CardName { Ace, Ten, Jack, Queen, King };

    private string[] cardLetters = { "A", "10", "J", "Q", "K" };
    private string[] cardNames = { "Assassin", "Captain", "Ambassador", "Contessa", "Duke" };

    public void setCardSuit(int cardSuit)
    {
        this.cardSuit = cardSuit;
    }

    public void setCardValue(int cardValue)
    {
        this.cardValue = cardValue;
    }

    public int getCardSuit()
    {
        return cardSuit;
    }

    public int getCardValue()
    {
        return cardValue;
    }

    public string toString()
    {
        string s = cardLetters[cardValue] + " " + cardNames[cardValue];
        print(s);
        return s;
    }
}
