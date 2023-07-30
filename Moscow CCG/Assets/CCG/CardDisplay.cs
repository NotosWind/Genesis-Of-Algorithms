using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CardDisplay : MonoBehaviour, IPointerClickHandler
{

    public Card card;

    public TMP_Text nameText;
    public TMP_Text effectText;

    public Image Sprite;
    public bool cardback;

    public TMP_Text Cost;
    public TMP_Text AttackText;
    public TMP_Text HealthText;

    public Deck deck;
    public Button shuffleButton;
    public Button drawButton;


    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;
        effectText.text = card.effect != null ? card.effect.description : "";

        Sprite.sprite = card.cardImage;
        //cardback.sprite = card.cardback;

        Cost.text = card.cost.ToString();
        AttackText.text = card.GetAttack().ToString();
        HealthText.text = card.GetHealth().ToString();

        shuffleButton.onClick.AddListener(deck.Shuffle);
    }

    void DrawCard()
    {
    GameObject drawnCard = deck.DrawCard();
    if (drawnCard != null)
    {
        FindObjectOfType<Hand>().AddCardToHand(gameObject);
    }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // Left click to select the card
            Debug.Log("Selected card: " + card.name);
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            // Right click to attack with the card
            Debug.Log("Attacking with card: " + card.name);

            // Find the enemy card to attack
            GameObject[] enemyCards = GameObject.FindGameObjectsWithTag("EnemyCard");
            GameObject enemyCard = null;
            foreach (GameObject card in enemyCards)
            {
                if (card.GetComponent<CardDisplay>().card.health > 0)
                {
                    enemyCard = card;
                    break;
                }
            }

            // If there is an enemy card to attack, deal damage
            if (enemyCard != null)
            {
                enemyCard.GetComponent<CardDisplay>().card.DealDamage(card.attack);
                card.TakeDamage(enemyCard.GetComponent<CardDisplay>().card.attack);
            }
        }
    }

    public void Die()
    {
        // Remove the card from the battlefield
        Destroy(gameObject);
    }

    public void UpdateCardInfo()
    {
        // Update the card's UI elements with the latest data
        Cost.text = card.cost.ToString();
        AttackText.text = card.GetAttack().ToString();
        HealthText.text = card.GetHealth().ToString();
    }

    void Update()
    {

    }
}
