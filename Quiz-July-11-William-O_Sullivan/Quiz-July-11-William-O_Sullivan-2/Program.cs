using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_July_11_William_O_Sullivan_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck = Cards.startDeck(1);
        }
    }
    
    class Cards
    {
        public static List<int> startDeck(int numDecks)
        {
            List<int> initial = new List<int>();
            List<int> shuffled = new List<int>();
            List<string> card = new List<string>();

            while (numDecks > 0)
            {
                for (int i = 2; i <= 14; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        initial.Add(i);
                        switch (j)
                        {
                            case 0:
                                card.Add(i + " of Hearts");
                                break;
                            case 1:
                                card.Add(i + " of Diamonds");
                                break;
                            case 2:
                                card.Add(i + " of Clubs");
                                break;
                            case 3:
                                card.Add(i + " of Spades");
                                break;
                            default:
                                break;
                        }
                    }
                }
            numDecks--;
            }

            Random r = new Random();
            int count = initial.Count;

            for (int i = 0; i < count; i++) 
            {

                int randomDraw = r.Next(0, initial.Count);

                shuffled.Insert(0, initial[randomDraw]);

                initial[randomDraw] = initial.Last();
                
                initial.RemoveAt(initial.Count - 1);

            }

            List<string> cards = new List<string>();
            Random rand = new Random();
            int counter = card.Count;
            for (int m = 0; m < card.Count; m++)
            {
                int number = rand.Next(0, counter);
                cards.Insert(0, card[number]);
                //card[number] = card.Last();
                //cards[m] = card[number];
                card.RemoveAt(number);
                counter--;
            }

                for (int l = 0; l < card.Count; l++)
                {
                    Console.WriteLine(cards[l]);
                }
            Console.ReadLine();
            return shuffled;
        }
    }
}
