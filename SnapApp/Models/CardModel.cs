namespace SnapApp.Models
{
    public enum Suit
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public class CardModel
    {
        public Suit CardSuit;
        public Face CardFace;
    }
}