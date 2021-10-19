using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rajiv.Ekansh.TwentyNine
{

    public class GameConroller : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Deck dck = new Deck();
            dck.Shuffle();
            Player player1 = new Player(1);
            Card[] playerHand = new Card[13];
            Array.Copy(dck.deck, 0, playerHand, 0, 13);
            player1.SetHand(playerHand);
            foreach(Card card in player1.hand)
            {
                Debug.Log(card.GetSuit() + " " + card.GetValue() + "\n");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
