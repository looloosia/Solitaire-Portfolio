using System.Collections.Generic;
using UnityEditor.Searcher;
using UnityEngine;

// 3개만 보이고 마지막 1개만 이동 가능
public class Waste
{
    private List<Card> cards = new List<Card>();

    public void AddCard(Card card)
    {
        cards.Add(card);
        Refresh();
    }

    // 클릭됐을 때
    void OnClick()
    {
        
    }

    // 카드가 나가거나 들어왔을 때 카드가 재배열됨
    void Refresh()
    {
        // 마지막으로 받은 카드만 moveable하게
        for (int count = 0; count < cards.Count; count++)
        {
            // 마지막 3개면 앞면
            cards[count].isFront = count >= cards.Count - 4;
            
            // 마지막 1개면 moveable하게
            cards[count].isMoveable = count == cards.Count - 1;
        }
    }
}
