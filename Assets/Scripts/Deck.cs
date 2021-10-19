using System;
using UnityEngine;
namespace Rajiv.Ekansh.TwentyNine
{
    public class Deck
    {

        internal Card[] deck = new Card[52];
        private Suit[] suits = { Suit.club, Suit.diamond, Suit.heart, Suit.spade };
        private CardValue[] values =
        {
            CardValue.A,
            CardValue.Two,
            CardValue.Three,
            CardValue.Four,
            CardValue.Five,
            CardValue.Six,
            CardValue.Seven,
            CardValue.Eight,
            CardValue.Nine,
            CardValue.Ten,
            CardValue.J,
            CardValue.Q,
            CardValue.K
        };

        public Deck()
        {
            int i = 0;
            foreach(Suit suit in suits)
            {
                foreach(CardValue value in values)
                {
                    deck[i] = new Card(suit, value);
                    i++;
                }
            }

        }

        public void Shuffle()
        {
            System.Random random = new System.Random();
            for (int i = deck.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);

                Card temp = deck[i];
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
        }
    }
}
