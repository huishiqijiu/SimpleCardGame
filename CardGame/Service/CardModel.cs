using CardGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame.Service
{
    public class CardModel
    {
        public CardModel(Card card)
        {
            Id = card.Id;
            Color = card.Color;
            Number = card.Number;
            IsFlippedUp = card.IsFlippedUp;
        }
        public CardModel()
        {

        }
        public int Id { get; set; }
        public string Color { get; set; }
        public int Number { get; set; }
        public bool IsFlippedUp { get; set; }

    }
}