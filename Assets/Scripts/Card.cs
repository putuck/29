using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rajiv.Ekansh.TwentyNine
{
    public enum Suit
    {
        club, diamond, heart, spade
    }

    public enum CardValue
    {
        A, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, J, Q, K
    }

    public class Card
    {

        private CardValue value;
        private Suit suit;

        public Card(Suit suit, CardValue value)
        {
            this.suit = suit;
            this.value = value;

        }

        public Suit GetSuit()
        {
            return this.suit;
        }

        public CardValue GetValue()
        {
            return this.value;
        }

    }
}
