
using CardGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Service
{
    public interface ICardService
    {
        IList<CardModel> GetCards(int numOfDecks);
        IList<CardModel> ShuffleCards(int numOfDecks);
    }
}
