
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Repository
{
    public interface ICardRepo
    {
        IList<Card> GetCards(int numOfDecks);
    }
}
