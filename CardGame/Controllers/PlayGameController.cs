using CardGame.Service;
using CardGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CardGame.Controllers
{
    public class PlayGameController : Controller
    {
        ICardService _service;
        public PlayGameController(ICardService service)
        {
            _service = service;
        }
        // GET: PlayGame
        public ActionResult Index()
        {
            //var model = new PlayGameViewModel { CardsFaceDown = _service.GetCards() };
            return View();
        }
        public ActionResult Play(int numOfDecks)
        {
            var model = new PlayGameViewModel { CardsFaceDown = _service.GetCards(numOfDecks), NumberOfDecks=numOfDecks };
            return View(model);
        }
        [HttpPost]
        public JsonResult ShuffleCards(int numOfDecks)
        {
            IList<CardModel> shuffledCards = _service.ShuffleCards(numOfDecks);
            return Json(shuffledCards, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SortCards(int numOfDecks)
        {
            IList<CardModel> sortedCards = _service.GetCards(numOfDecks);
            return Json(sortedCards, JsonRequestBehavior.AllowGet);
        }
    }
}