using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pianist> pianists = new List<Pianist>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] segments = Console.ReadLine().Split("|");
                Pianist pianist = new Pianist(segments[0], segments[1], segments[2]);
                pianists.Add(pianist);
            }
            string commands;
            while ((commands = Console.ReadLine()) != "Stop")
            {
                string[] segments = commands.Split("|");
                string command = segments[0];
                string piece = segments[1];
                switch (command)
                {
                    case "Add":
                        string composer = segments[2];
                        string key = segments[3];
                        Pianist pianist1 = new Pianist(piece, composer, key);
                        bool isExists = false;
                        foreach (Pianist x in pianists)
                        {
                            if (piece == x.Piece)
                            {
                                isExists = true;

                            }
                        }
                        if (!isExists)
                        {
                            pianists.Add(pianist1);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;
                    case "Remove":
                        bool isRemoved = false;
                        foreach (Pianist x in pianists)
                        {
                            if (x.Piece == piece)
                            {
                                pianists.Remove(x);
                                Console.WriteLine($"Successfully removed {piece}!");
                                isRemoved = true;
                                break;
                            }
                        }
                        if (!isRemoved)
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        string newKey = segments[2];
                        bool isChanged = false;
                        foreach (Pianist x in pianists)
                        {
                            if (x.Piece == piece)
                            {
                                x.Key = newKey;
                                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                                isChanged = true;
                                break;
                            }
                        }
                        if (!isChanged)
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
            }
                foreach (Pianist x in pianists)
                {
                    Console.WriteLine(x.ToString());
                }
    }
        class Pianist
        {
            public string Piece { get; set; }
            public string Composer { get; set; }
            public string Key { get; set; }

            public Pianist(string piece, string composer, string key)
            {
                this.Piece = piece;
                this.Composer = composer;
                this.Key = key;
            }
            public override string ToString()
            {
                return $"{this.Piece} -> Composer: {this.Composer}, Key: {this.Key}";
            }
        }
    }
}

