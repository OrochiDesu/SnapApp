using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Scope;
using SnapApp.Models;

namespace SnapApp.Controllers
{
    public class CardController : Controller
    {

        //Get Card Value
        public int[] CardValue(CardModel card)
        {
            var cardVal = (int) card.CardFace + 1; // 0 based god

            if (cardVal == 1)
            {
                return new[] {1, 11};
            }
            if (cardVal > 10)
            {
                return new[] {10};
            }
            return new[] {cardVal};
        }
    }
}
