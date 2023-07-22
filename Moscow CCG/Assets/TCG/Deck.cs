using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    [System.Serializable]
    public class CardData
    {
        public string cardName;
        public int attack;
        public int health;
        public int quantity;
    }    
    public List<CardData> cardDataList = new List<CardData>();
    public GameObject cardPrefab;
    public Button drawButton;

    private List<GameObject> cards = new List<GameObject>();

    private void Start()
    {
        drawButton.onClick.AddListener(DrawCardAndAddToHand);
        CreateDeck();
        Shuffle();
    }

    private void CreateDeck()
    {
        foreach (CardData cardData in cardDataList)
        {
            for (int i = 0; i < cardData.quantity; i++)
            {
                CreateCard(cardData);
            }
        }
    }

    private void CreateCard(CardData cardData)
    {
        GameObject cardGO = Instantiate(cardPrefab, transform);
        CardDisplay cardDisplay = cardGO.GetComponent<CardDisplay>();
        cardDisplay.card = new Card();
        cardDisplay.card.Init(cardDisplay);
        cardDisplay.card.attack = cardData.attack;
        cardDisplay.card.health = cardData.health;
        cardDisplay.UpdateCardInfo();
        AddCard(cardGO);
    }

    public void AddCard(GameObject card)
    {
        cards.Add(card);
    }

    public void Shuffle()
    {
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            GameObject temp = cards[i];
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
        }
    }

    public GameObject DrawCard()
    {
        if (cards.Count == 0)
        {
            Debug.LogError("The deck is empty!");
            return null;
        }

        GameObject drawnCard = cards[0];
        cards.RemoveAt(0);
        return drawnCard;
    }

    public void DrawCardAndAddToHand()
    {
        GameObject drawnCard = DrawCard();
        if (drawnCard != null)
        {
            FindObjectOfType<Hand>().AddCardToHand(drawnCard);
        }
    }
}