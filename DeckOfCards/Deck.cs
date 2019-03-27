using System;

namespace DeckOfCards
{
    public class Deck
    {
        private Random random;
        private string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };
        private string[] faceValues = { "1", "2", "3", "4", "5" };


        public Deck()
        {
            random = new Random();


            //there are 52 cards in the deck
            Cards = new Card[52];

            for(int i = 0; i < Cards.Length; i++)
            {
                //populate the deck with cards from the Card class
                //fill with blank cards
                Cards[i] = new Card();
            }

            // TODO: Load the card deck with a standard deck of 52 cards.  Use loops, do not hard code each one.
            //for suits- 4 suits - 13 cards in each suit
            //assign suit
            int cardCount = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    
                    Card card = Cards[cardCount];
                    card.Suit = suits[i];
                    card.FaceValue = faceValues[j];
                    cardCount++;
                }
            }
        }


        public Card[] Cards { get; set; }

        public Card Draw()
        {
            int randomIndex = random.Next(0, 20);
            Card card = Cards[randomIndex];
            // TODO: Return a random card from the deck.
            return null;
        }
    }
}