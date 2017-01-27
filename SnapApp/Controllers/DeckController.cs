using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SnapApp.Models;

namespace SnapApp.Controllers
{
    public class DeckController : Controller
    {
        // Build Deck
        public void AssembleDeck()
        {
            var deck = new DeckModel { CardDeck = new List<CardModel>() };
            var suitCount = Enum.GetNames(typeof(Suit)).Length;
            var faceCount = Enum.GetNames(typeof(Face)).Length;

            for (var i = 0; i < suitCount; i++)
            {
                for (var j = 0; j < faceCount; j++)
                {
                    var card = new CardModel()
                    {
                        CardSuit = (Suit)i,
                        CardFace = (Face)j
                    };
                    deck.CardDeck.Add(card);
                }
            }
        }
    }
}