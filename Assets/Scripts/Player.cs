using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rajiv.Ekansh.TwentyNine
{

    public class Player
    {
        private int id;
        internal Card[] hand;

        public Player(int id)
        {
            this.id = id;
            hand = new Card[13];
        }

        public void SetHand(Card[] cards)
        {
            hand = cards;
        }

        public Card[] GetHand()
        {
            return hand;
        }
    }
}
