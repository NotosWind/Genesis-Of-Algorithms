using UnityEngine;

[CreateAssetMenu(fileName = "New Effect", menuName = "Card Effect")]
public class CardEffect : ScriptableObject
{
    public string effectName;
    public string description;
    public int attackModifier;
    public int healthModifier;

    // New properties for different types of effects
    public bool doesDamageWhenPlayed; // Does the card deal damage when played?
    public int damageWhenPlayed; // How much damage does the card deal when played?

    public bool healsWhenPlayed; // Does the card heal the player when played?
    public int healWhenPlayed; // How much does the card heal the player when played?

    // New method to trigger the effect when the card is played
    public void TriggerEffectWhenPlayed()
    {
        if (doesDamageWhenPlayed)
        {
            // Code to deal damage
        }

        if (healsWhenPlayed)
        {
            // Code to heal the player
        }
    }
}
