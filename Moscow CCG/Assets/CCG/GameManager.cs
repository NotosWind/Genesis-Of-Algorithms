using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Deck deck;
    public Hand hand;
    public TurnManager turnManager;

    public void StartGame()
    {
        deck.Shuffle();
        for (int i = 0; i < 5; i++)
        {
            Card card = deck.DrawCard();
            hand.AddCard(card);
        }
        turnManager.isPlayerTurn = true;
    }

    public void EndTurn()
    {
        turnManager.EndTurn();
        if (turnManager.isPlayerTurn)
        {
            Card card = deck.DrawCard();
            hand.AddCard(card);
        }
    }
}