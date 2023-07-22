using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public bool isPlayerTurn;

    public void EndTurn()
    {
        isPlayerTurn = !isPlayerTurn;
    }
}
