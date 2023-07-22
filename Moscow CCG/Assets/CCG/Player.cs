using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Deck deck;
    public Hand hand;
    public int health;
    public int coins;

    private void Start()
    {
        health = 20;
        coins = 10;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            // Game Over
        }
    }

    public void GainCoins(int amount)
    {
        coins += amount;
    }

    public void SpendCoins(int amount)
    {
        if (coins >= amount)
        {
            coins -= amount;
        }
        else
        {
            // Not enough coins
        }
    }
}