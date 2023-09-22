// See https://aka.ms/new-console-template for more information
using Stacks_Lumpkin_Dalton;
//hello world :D
Console.WriteLine("Hello, World!");
//card array
Card[] myCardsArray = new Card[]
{
    
    new Card ("A", "Spades"),
    new Card ("J", "Spades"),
    new Card ("Q", "Diamonds"),
    new Card ("Q", "Diamonds"),
    new Card ("10", "Diamonds"),
    new Card ("2", "Diamonds"),
    new Card ("6", "Diamonds"),
    new Card ("9", "Diamonds"),
    new Card ("A", "Diamonds"),

};
//sets
Stack<Card> Decky = new Stack<Card> (myCardsArray);
//says cards in deck
Console.WriteLine("Cards in Deck:");
foreach (Card card in Decky)
{
    Console.WriteLine ($"The {card.Num} of {card.Suit}!");
}
Console.WriteLine($"Cards in the stack: {Decky.Count}");
//sets my hand
List<Card> myHand = new List<Card> ();
myHand.Add(new Card("Jack", "Diamond"));
myHand.Add(new Card("8", "Hearts"));
myHand.Add(new Card("3", "Diamond"));

Console.WriteLine("Got 8's M8?");
//my favorite statements of all time <3
if(Decky.Count > 0)
{
    myHand.Add(Decky.Pop());
}
//tells u number of cards in deck
Console.WriteLine($"Cards in the stack: {Decky.Count}");

Decky.Push(myHand[0]);
myHand.RemoveAt(0);


Console.WriteLine("Cards in Deck:");
//second favorite statement :)
foreach (Card card in Decky)
{
    Console.WriteLine($"The {card.Num} of {card.Suit}!");
}