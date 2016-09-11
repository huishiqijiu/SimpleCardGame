using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CardGame.Repository;

namespace CardGame.Service
{
    public class CardService : ICardService
    {
        ICardRepo _repo;
        public CardService (ICardRepo repo)
        {
            _repo = repo;
        }
        public IList<CardModel> GetCards(int numOfDecks)
        {
            return _repo.GetCards(numOfDecks).Select(x => new CardModel(x)).ToList();
                    
        }     
        public IList<CardModel> ShuffleCards(int numOfDecks)
        {           
            var cardsInOrder = _repo.GetCards(numOfDecks).Select(x => new CardModel(x)).ToList();
            List<CardModel> shuffledCards = new List<CardModel>();
            Random r = new Random();
            int randomIndex = 0;
            while (cardsInOrder.Count > 0)
            {
                randomIndex = r.Next(0, cardsInOrder.Count); //Choose a random object in the list
                shuffledCards.Add(cardsInOrder[randomIndex]); //add it to the new, random list
                cardsInOrder.RemoveAt(randomIndex); //remove to avoid duplicates
            }
            return shuffledCards; //return the new random list
        }
    }
}