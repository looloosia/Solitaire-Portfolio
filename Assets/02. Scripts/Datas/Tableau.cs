using System.Collections.Generic;
using UnityEngine;

// 맨마지막 카드만 앞면
public class Tableau
{
    private List<Card> cards = new List<Card>();

    public void AddCard(Card card)
    {
        cards.Add(card);
        Refresh();
    }

    // 카드가 추가되거나 빠져나갈 때마다
    private void Refresh()
    {
        foreach (Card card in cards)
        {
            card.isFront = false;
        }
        cards[cards.Count - 1].isFront = true;
    }
}
