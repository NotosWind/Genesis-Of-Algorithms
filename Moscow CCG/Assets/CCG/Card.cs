using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public enum CardType
    {
        Leader,
        Supporter,
        Effect,
        Equipment,
        Trap
    }

    public CardType type;
    public string cardName;
    public int attack;
    public int health;
    public CardDisplay display;

    public void InitializeCard(string name, int attack, int health, CardType type)
    {
        this.cardName = name;
        this.attack = attack;
        this.health = health;
        this.type = type;

        if (display != null)
        {
            display.UpdateCard();
        }
    }
}