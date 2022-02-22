using System;
using System.Collections.Generic;

namespace HFCardComparer
{
    internal class Program
    {
        private static Random rnd = new Random();

        static Card RandomCard()
        {
            return new Card((Values)rnd.Next(1, 14), (Suits)rnd.Next(4));
        }
        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            { 
                Console.WriteLine(card.Name);
            }
        
        }

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Console.WriteLine("Enter number of cards: ");

            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
            { 
                for(int i = 0; i < numberOfCards; i++)
                    cards.Add(RandomCard());
            }
            PrintCards(cards);

            cards.Sort(new CardComparerByValue());
            Console.WriteLine("\n ...sorting cards...\n");

            PrintCards(cards);
        }
    }
}
