using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CardGame.Repository
{
    public class CardRepo : ICardRepo
    {
        public IList<Card> GetCards(int numOfDecks)
        {
            Card c1 = new Card
            {
                Id = 1,
                Color = "Heart",
                Number = 1,
                IsFlippedUp = false,
            };
            Card c2 = new Card
            {
                Id = 2,
                Color = "Heart",
                Number = 2,
                IsFlippedUp = false,
            };
            Card c3 = new Card
            {
                Id = 3,
                Color = "Heart",
                Number = 3,
                IsFlippedUp = false,
            };
            Card c4 = new Card
            {
                Id = 4,
                Color = "Heart",
                Number = 4,
                IsFlippedUp = false,
            };
            Card c5 = new Card
            {
                Id = 5,
                Color = "Heart",
                Number = 5,
                IsFlippedUp = false,
            };
            Card c6 = new Card
            {
                Id = 6,
                Color = "Heart",
                Number = 6,
                IsFlippedUp = false,
            };
            Card c7 = new Card
            {
                Id = 7,
                Color = "Heart",
                Number = 7,
                IsFlippedUp = false,
            };
            Card c8 = new Card
            {
                Id = 8,
                Color = "Heart",
                Number = 8,
                IsFlippedUp = false,
            };
            Card c9 = new Card
            {
                Id = 9,
                Color = "Heart",
                Number = 9,
                IsFlippedUp = false,
            };
            Card c10 = new Card
            {
                Id = 10,
                Color = "Heart",
                Number = 10,
                IsFlippedUp = false,
            };
            Card c11 = new Card
            {
                Id = 11,
                Color = "Heart",
                Number = 11,
                IsFlippedUp = false,
            };
            Card c12 = new Card
            {
                Id = 12,
                Color = "Heart",
                Number = 12,
                IsFlippedUp = false,
            };
            Card c13 = new Card
            {
                Id = 13,
                Color = "Heart",
                Number = 13,
                IsFlippedUp = false,
            };
            Card c14 = new Card
            {
                Id = 14,
                Color = "Spade",
                Number = 1,
                IsFlippedUp = false,
            };
            Card c15 = new Card
            {
                Id = 15,
                Color = "Spade",
                Number = 2,
                IsFlippedUp = false,
            };
            Card c16 = new Card
            {
                Id = 14,
                Color = "Spade",
                Number = 3,
                IsFlippedUp = false,
            };
            Card c17 = new Card
            {
                Id = 17,
                Color = "Spade",
                Number = 4,
                IsFlippedUp = false,
            };
            Card c18 = new Card
            {
                Id = 18,
                Color = "Spade",
                Number = 5,
                IsFlippedUp = false,
            };
            Card c19 = new Card
            {
                Id = 19,
                Color = "Spade",
                Number = 6,
                IsFlippedUp = false,
            };
            Card c20 = new Card
            {
                Id = 20,
                Color = "Spade",
                Number = 7,
                IsFlippedUp = false,
            };
            Card c21 = new Card
            {
                Id = 21,
                Color = "Spade",
                Number = 8,
                IsFlippedUp = false,
            };
            Card c22 = new Card
            {
                Id = 22,
                Color = "Spade",
                Number = 9,
                IsFlippedUp = false,
            };
            Card c23 = new Card
            {
                Id = 23,
                Color = "Spade",
                Number = 10,
                IsFlippedUp = false,
            };
            Card c24 = new Card
            {
                Id = 24,
                Color = "Spade",
                Number = 11,
                IsFlippedUp = false,
            };
            Card c25 = new Card
            {
                Id = 25,
                Color = "Spade",
                Number = 12,
                IsFlippedUp = false,
            };
            Card c26 = new Card
            {
                Id = 26,
                Color = "Spade",
                Number = 13,
                IsFlippedUp = false,
            };
            Card c27 = new Card
            {
                Id = 27,
                Color = "Club",
                Number = 1,
                IsFlippedUp = false,
            };
            Card c28 = new Card
            {
                Id = 28,
                Color = "Club",
                Number = 2,
                IsFlippedUp = false,
            };
            Card c29 = new Card
            {
                Id = 29,
                Color = "Club",
                Number = 3,
                IsFlippedUp = false,
            };
            Card c30 = new Card
            {
                Id = 30,
                Color = "Club",
                Number = 4,
                IsFlippedUp = false,
            };
            Card c31 = new Card
            {
                Id = 31,
                Color = "Club",
                Number = 5,
                IsFlippedUp = false,
            };
            Card c32 = new Card
            {
                Id = 32,
                Color = "Club",
                Number = 6,
                IsFlippedUp = false,
            };
            Card c33 = new Card
            {
                Id = 33,
                Color = "Club",
                Number = 7,
                IsFlippedUp = false,
            };
            Card c34 = new Card
            {
                Id = 34,
                Color = "Club",
                Number = 8,
                IsFlippedUp = false,
            };
            Card c35 = new Card
            {
                Id = 35,
                Color = "Club",
                Number = 9,
                IsFlippedUp = false,
            };
            Card c36 = new Card
            {
                Id = 36,
                Color = "Club",
                Number = 10,
                IsFlippedUp = false,
            };
            Card c37 = new Card
            {
                Id = 37,
                Color = "Club",
                Number = 11,
                IsFlippedUp = false,
            };
            Card c38 = new Card
            {
                Id = 38,
                Color = "Club",
                Number = 12,
                IsFlippedUp = false,
            };
            Card c39 = new Card
            {
                Id = 39,
                Color = "Club",
                Number = 13,
                IsFlippedUp = false,
            };
            Card c40 = new Card
            {
                Id = 40,
                Color = "Diamond",
                Number = 1,
                IsFlippedUp = false,
            };
            Card c41 = new Card
            {
                Id = 41,
                Color = "Diamond",
                Number = 2,
                IsFlippedUp = false,
            };
            Card c42 = new Card
            {
                Id = 42,
                Color = "Diamond",
                Number = 3,
                IsFlippedUp = false,
            };
            Card c43 = new Card
            {
                Id = 43,
                Color = "Diamond",
                Number = 4,
                IsFlippedUp = false,
            };
            Card c44 = new Card
            {
                Id = 44,
                Color = "Diamond",
                Number = 5,
                IsFlippedUp = false,
            };
            Card c45 = new Card
            {
                Id = 45,
                Color = "Diamond",
                Number = 6,
                IsFlippedUp = false,
            };
            Card c46 = new Card
            {
                Id = 46,
                Color = "Diamond",
                Number = 7,
                IsFlippedUp = false,
            };
            Card c47 = new Card
            {
                Id = 47,
                Color = "Diamond",
                Number = 8,
                IsFlippedUp = false,
            };
            Card c48 = new Card
            {
                Id = 48,
                Color = "Diamond",
                Number = 9,
                IsFlippedUp = false,
            };
            Card c49 = new Card
            {
                Id = 49,
                Color = "Diamond",
                Number = 10,
                IsFlippedUp = false,
            };
            Card c50 = new Card
            {
                Id = 50,
                Color = "Diamond",
                Number = 11,
                IsFlippedUp = false,
            };
            Card c51 = new Card
            {
                Id = 51,
                Color = "Diamond",
                Number = 12,
                IsFlippedUp = false,
            };
            Card c52 = new Card
            {
                Id = 52,
                Color = "Diamond",
                Number = 13,
                IsFlippedUp = false,
            };
            List<Card> cards = new List<Card>();
            cards.Add(c1);
            cards.Add(c2);
            cards.Add(c3);
            cards.Add(c4);
            cards.Add(c5);
            cards.Add(c6);
            cards.Add(c7);
            cards.Add(c8);
            cards.Add(c9);
            cards.Add(c10);
            cards.Add(c11);
            cards.Add(c12);
            cards.Add(c13);
            cards.Add(c14);
            cards.Add(c15);
            cards.Add(c16);
            cards.Add(c17);
            cards.Add(c18);
            cards.Add(c19);
            cards.Add(c20);
            cards.Add(c21);
            cards.Add(c22);
            cards.Add(c23);
            cards.Add(c24);
            cards.Add(c25);
            cards.Add(c26);
            cards.Add(c27);
            cards.Add(c28);
            cards.Add(c29);
            cards.Add(c30);
            cards.Add(c31);
            cards.Add(c32);
            cards.Add(c33);
            cards.Add(c34);
            cards.Add(c35);
            cards.Add(c36);
            cards.Add(c37);
            cards.Add(c38);
            cards.Add(c39);
            cards.Add(c40);
            cards.Add(c41);
            cards.Add(c42);
            cards.Add(c43);
            cards.Add(c44);
            cards.Add(c45);
            cards.Add(c46);
            cards.Add(c47);
            cards.Add(c48);
            cards.Add(c49);
            cards.Add(c50);
            cards.Add(c51);
            cards.Add(c52);
            //List<string> rank = new List<string>();
            //rank.Add("Heart");
            //rank.Add("Spade");
            //rank.Add("Diamond");
            //rank.Add("Club");
            switch (numOfDecks)
            {
                case 1:
                    return cards;
                case 2:
                    return cards.Concat(cards).ToList();
                case 3:
                    return cards.Concat(cards).Concat(cards).ToList();
                default: throw new ArgumentOutOfRangeException();
            }
           
        }
    }
}