
using CardGame.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame.ViewModels
{
    public class PlayGameViewModel
    {
        public int NumberOfDecks { get; set; }
        public IList<CardModel> CardsFaceDown { get; set; }
        public CardModel CardFlippedUp { get; set; }
    }
}