using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Stock
{
    private List<Card> cards = new List<Card>();
    public List<Card> Cards => cards;
    [SerializeField] private Waste waste;
    
    // 스톡이 클릭될 때 실행
    public void OnClick()
    {
        // TODO: 맨 위 카드를 waste로 옮기기
        waste.AddCard(cards[cards.Count - 1]);
        cards.RemoveAt(cards.Count - 1);
    }
}
