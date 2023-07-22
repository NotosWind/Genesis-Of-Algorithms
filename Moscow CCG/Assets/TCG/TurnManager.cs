using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public enum GameState
    {
        Player1Turn,
        Player2Turn,
        GameOver
    }

    public GameState currentState;

    private void Start()
    {
        currentState = GameState.Player1Turn;
    }

    public void EndTurn()
    {
        if (currentState == GameState.Player1Turn)
        {
            currentState = GameState.Player2Turn;
        }
        else if (currentState == GameState.Player2Turn)
        {
            currentState = GameState.Player1Turn;
        }
    }

    private void Update()
    {
        if (currentState == GameState.GameOver)
        {
            return;
        }

        if (currentState == GameState.Player1Turn)
        {
            // Handle player 1's turn
        }
        else if (currentState == GameState.Player2Turn)
        {
            // Handle player 2's turn
        }
    }
}