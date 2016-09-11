using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame.Repository
{
    public class Card
    {
        public Card()
        {

        }
        public int Id { get; set; }
        public string Color { get; set; }
        public int Number { get; set; }
        public bool IsFlippedUp { get; set; }
    }
}