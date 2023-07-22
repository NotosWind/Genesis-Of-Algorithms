using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZone : MonoBehaviour
{
    public List<Card> cardsInZone = new List<Card>();

    public void AddCard(Card card)
    {
        cardsInZone.Add(card);
    }

    public void RemoveCard(Card card)
    {
        cardsInZone.Remove(card);
    }
}
