using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Heal Action", menuName = "Card Action/Heal")]
public class HealAction : CardAction
{
    public int healAmount;

    public override void Execute(Card card)
    {
        // Implement the logic for the heal action here
        // For example, you can increase the card's health by the heal amount
        card.currentHealth += healAmount;
        if (card.currentHealth > target.maxHealth)
        {
            card.currentHealth = target.maxHealth;
        }
    }
}