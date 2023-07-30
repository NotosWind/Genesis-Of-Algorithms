using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    public Transform handZone;

    public void AddCardToHand(GameObject card)
    {
        Deck deck = FindObjectOfType<Deck>();
        Button shuffleButton = GameObject.Find("ShuffleButton").GetComponent<Button>();
        Button drawButton = GameObject.Find("DrawButton").GetComponent<Button>();

        Vector3 originalScale = card.transform.localScale; // Save the original scale
        GameObject newCard = Instantiate(card, handZone);
        newCard.GetComponent<CardDisplay>().deck = deck;
        // newCard.GetComponent<CardDisplay>().hand = hand;
        newCard.GetComponent<CardDisplay>().shuffleButton = shuffleButton;
        newCard.GetComponent<CardDisplay>().drawButton = drawButton;
        newCard.transform.localScale = originalScale; // Set the scale of the instantiated card to the original scale
    }
}