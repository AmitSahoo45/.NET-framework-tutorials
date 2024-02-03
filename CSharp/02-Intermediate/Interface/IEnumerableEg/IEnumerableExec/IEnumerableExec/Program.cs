using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEnumerableExec;

namespace IEnumerableExec
{
    public class Card
    {
        public string CardName { get; set; }
    }

    public class Deck : IEnumerable<Card>
    {
        public List<Card> Cards;

        public Deck(List<Card> cards)
        {
            this.Cards = cards;
        }

        public IEnumerable<string> displayCards()
        {
            foreach(var card in Cards)
                yield return card.CardName;
        }

        public IEnumerator<Card> GetEnumerator()
        {
            foreach (var card in Cards)
                yield return card;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Enumerability
    {
        static IEnumerable<string> getNames(bool isCheck = false)
        {
            yield return "Amit";
            yield return "Sumit";
            yield return "Rahul";

            if (!isCheck)
                yield break;

            yield return "Rohit";
            yield return "Raj";
        }

        public void DisplayNames()
        {
            foreach (var name in getNames())
                Console.WriteLine(name);
        }
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        //var deck = new Deck(new List<Card>
        //{
        //    new Card { CardName = "Ace of Hearts" },
        //    new Card { CardName = "2 of Hearts" },
        //    new Card { CardName = "3 of Hearts" },
        //    new Card { CardName = "4 of Hearts" },
        //    new Card { CardName = "5 of Hearts" },
        //    new Card { CardName = "6 of Hearts" },
        //    new Card { CardName = "7 of Hearts" },
        //    new Card { CardName = "8 of Hearts" },
        //    new Card { CardName = "9 of Hearts" },
        //    new Card { CardName = "10 of Hearts" },
        //    new Card { CardName = "Jack of Hearts" },
        //    new Card { CardName = "Queen of Hearts" },
        //    new Card { CardName = "King of Hearts" }
        //});

        //foreach (var card in deck)
        //    Console.WriteLine(card.CardName);

        //int? num1 = null;

        //int res = num1 ?? 0; // If num1 is null, then set it to 0

        var enu = new Enumerability();
        enu.DisplayNames();


        Console.ReadKey();
    }
}

// Notes:
/*
 * Here we are creating a 'Deck' class that acts as a custom collection of Card instances.
 * The Deck class implements IEnumerable, enabling the use of foreach loops to iterate through each card in the deck.
 * Just like you would in a real card game.
 * you can create a custom collection (like your Deck class) without explicitly implementing IEnumerable. However, implementing IEnumerable or IEnumerable<T> provides certain advantages, especially when you want to use the collection in a foreach loop or with LINQ queries.
 *
 * If you don't implement IEnumerable in your Deck class, you won't be able to use it in a foreach loop directly, and you'll lose the ability to leverage LINQ queries. The foreach loop relies on the ability to iterate over elements using the GetEnumerator method, which is part of the IEnumerable interface.
 *
 * if you try to use the deck instance in a foreach loop, it will result in a compilation error:
 * // Error: 'Deck' does not contain a public definition for 'GetEnumerator'
 *
 * To make it work without implementing IEnumerable, you would need to expose a method to iterate over the cards or use the List<Card> directly:
 *
*/
