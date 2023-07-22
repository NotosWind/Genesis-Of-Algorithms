using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public int cost;
    public int attack;
    public int health;
    public Sprite cardImage;
    public CardEffect effect;
    public CardType cardType;
    public Sprite cardback;

    public int GetAttack()
    {
        return attack + (effect != null ? effect.attackModifier : 0);
    }

    public int GetHealth()
    {
        return health + (effect != null ? effect.healthModifier : 0);
    }

    private CardDisplay cardDisplay;

    public void Init(CardDisplay cardDisplay)
    {
        this.cardDisplay = cardDisplay;
    }

    public void DealDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            cardDisplay.Die();
        }
    }

    public void TakeDamage(int damage)
    {
        attack -= damage;
        if (attack <= 0)
        {
            cardDisplay.Die();
        }
    }

}

public enum CardType
{
    Spell,
    Minion
}