using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack Action", menuName = "Card Action/Attack")]
public class AttackAction : CardAction
{
    public int damage;

    public override void Execute(Card card)
    {
        // Implement the logic for the attack action here
        // For example, you can decrease the target card's health by the damage amount
        Card targetCard = // get the target card
        targetCard.currentHealth -= damage;
    }

}