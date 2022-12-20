using System.Collections.Generic;
using UnityEngine;

// ReSharper disable All

public class CardStack
{
    [SerializeField] private List<Card> _cards;

    public CardStack()
    {
        _cards = new List<Card>();
    }

    public Card DrawCard()
    {
        return _cards[_cards.Count - 1];
    }
}
