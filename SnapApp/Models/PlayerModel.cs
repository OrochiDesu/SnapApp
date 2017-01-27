using System.Collections.Generic;

namespace SnapApp.Models
{
    public class PlayerModel
    {
        public List<CardModel> Hand { get; set; }

        public PlayerModel()
        {
            Hand = new List<CardModel>();
        }
    }
}