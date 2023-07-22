using UnityEngine;

[CreateAssetMenu(fileName = "New Effect", menuName = "Card Effect")]
public class CardEffect : ScriptableObject
{
    public string effectName;
    public string effectDescription;
    public int attackModifier;
    public int healthModifier;
    public string description;
}