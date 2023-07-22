using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CardEffect", menuName = "Card Effect")]
public class CardEffect : ScriptableObject
{
    public string effectName;
    public string effectDescription;
    public int attackModifier;
    public int healthModifier;

    public void ApplyEffect(Card card)
    {
        card.attack += attackModifier;
        card.health += healthModifier;
    }
}
