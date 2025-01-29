using System.Text;

namespace Cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    string[] cardData = input[i].Split();

                    string face = cardData[0];
                    string suit = cardData[1];

                    Card card = CreateCard(face, suit);
                    cards.Add(card);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine(string.Join(" ", cards));
        }

        public class Card
        {
            private readonly List<string> faces = new List<string> { "2", "3", "4", "5", "6",
                "7", "8", "9", "10", "J", "Q", "K", "A" };
            private readonly List<string> suits = new List<string> { "S", "H", "D", "C" };

            private string face;
            private string suit;

            public Card(string face, string suit)
            {
                Face = face;
                Suit = suit;
            }

            public string Face
            {
                get { return face; }
                set
                {
                    if (!faces.Contains(value))
                    {
                        throw new ArgumentException("Invalid card!");
                    }
                    else
                    {
                        face = value;
                    }
                }
            }

            public string Suit
            {
                get { return suit; }
                set
                {
                    if (!suits.Contains(value))
                    {
                        throw new ArgumentException("Invalid card!");
                    }
                    else
                    {
                        suit = value;
                    }
                }
            }

            public override string ToString()
            {
                byte[] bytes;
                StringBuilder sb = new StringBuilder();
                sb.Append($"[{face}");
                string suitToAppend;

                switch (suit)
                {
                    case "S":
                        bytes = Encoding.UTF8.GetBytes("\u2660");
                        suitToAppend = Encoding.UTF8.GetString(bytes);
                        sb.Append($"{suitToAppend}]");
                        break;

                    case "H":
                        bytes = Encoding.UTF8.GetBytes("\u2665");
                        suitToAppend = Encoding.UTF8.GetString(bytes);
                        sb.Append($"{suitToAppend}]");
                        break;

                    case "D":
                        bytes = Encoding.UTF8.GetBytes("\u2666");
                        suitToAppend = Encoding.UTF8.GetString(bytes);
                        sb.Append($"{suitToAppend}]");
                        break;

                    case "C":
                        bytes = Encoding.UTF8.GetBytes("\u2663");
                        suitToAppend = Encoding.UTF8.GetString(bytes);
                        sb.Append($"{suitToAppend}]");
                        break;
                }

                return sb.ToString();
            }
        }

        public static Card CreateCard(string face, string suit)
        {
            Card card = new Card(face, suit);
            return card;
        }
    }
}