using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    public int cardSuit;
    public int cardValue;

    private enum CardSuit {Spades, Hearts, Diamonds, Clubs};
    private enum CardName {Assassin, Captain, Ambassador, Queen, King};

    private string[] cardLetters = {"A", "10", "J", "Q", "K" };
    private string[] cardNames = { "Assassin", "Captain", "Ambassador", "Queen", "King"};

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

    public Card(int suit, int value)
    {
        cardSuit = suit;
        cardValue = value;
    }

    public string toString()
    {
        string s = cardLetters[cardValue] + " " + cardNames[cardValue];
        print(s);
        return s;
    }
}
