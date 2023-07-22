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
    
    public string cardName;
    public int cost;
    public Sprite artwork;
    public int attack;
    public int maxHealth;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void InitializeCard(string name, int attack, int health, CardType type)
    {
        this.cardName = name;
        this.attack = attack;
        this.maxHealth = health;
        //this.type = type

        // if (display != null)
        // {
        //     display.UpdateCard();
        // }
    }
}