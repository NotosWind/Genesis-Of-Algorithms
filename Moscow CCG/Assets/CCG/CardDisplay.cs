using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Text nameText;
    public Text attackText;
    public Text healthText;
    public Text typeText;

    public void UpdateCard()
    {
        nameText.text = card.cardName;
        attackText.text = card.attack.ToString();
        healthText.text = card.maxHealth.ToString();
        //typeText.text = card.type.ToString();
    }
}
