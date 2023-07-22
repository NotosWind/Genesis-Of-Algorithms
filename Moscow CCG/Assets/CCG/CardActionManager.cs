using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardActionManager : MonoBehaviour
{
    public void ExecuteAction(CardAction action, Card card)
    {
        action.Execute(card);
    }
}