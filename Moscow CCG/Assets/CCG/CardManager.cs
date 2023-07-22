using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> deck;
    public List<Card> hand;

    public void DrawCard()
    {
        if (deck.Count > 0)
        {
            int index = Random.Range(0, deck.Count);
            Card card = deck[index];
            deck.RemoveAt(index);
            hand.Add(card);
        }
    }

    public void PlayCard(int index)
    {
        if (index >= 0 && index < hand.Count)
        {
            Card card = hand[index];
            hand.RemoveAt(index);
            // TODO: Implement the logic to play the card
        }
    }
}
