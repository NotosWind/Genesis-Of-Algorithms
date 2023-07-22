using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardAction : ScriptableObject
{
    public abstract void Execute(Card card);
}