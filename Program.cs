using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GuessWho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess Who.");
            Characters Liam = new Characters()
            {
                name = "Liam",
                hat = true,
                glasses = true,
                male = true,
                hairColor = "Red",
                facialHair = false,
                eyeColor = "Green",
                earrings = false,
            };
            Characters Noah = new Characters()
            {
                name = "Noah",
                hat = true,
                glasses = false,
                male = true,
                hairColor = "Blonde",
                facialHair = true,
                eyeColor = "Blue",
                earrings = false,
            };
            Characters Oliver = new Characters()
            {
                name = "Oliver",
                hat = true,
                glasses = true,
                male = true,
                hairColor = "Black",
                facialHair = false,
                eyeColor = "Brown",
                earrings = false,
            };
            Characters William = new Characters()
            {
                name = "William",
                hat = true,
                glasses = false,
                male = true,
                hairColor = "Brown",
                facialHair = true,
                eyeColor = "Green",
                earrings = false,
            };
            Characters Elijah = new Characters()
            {
                name = "Elijah",
                hat = true,
                glasses = true,
                male = true,
                hairColor = "Red",
                facialHair = true,
                eyeColor = "Blue",
                earrings = false,
            };
            Characters James = new Characters()
            {
                name = "James",
                hat = true,
                glasses = false,
                male = true,
                hairColor = "Blonde",
                facialHair = false,
                eyeColor = "Brown",
                earrings = false,
            };
            Characters Ben = new Characters()
            {
                name = "Ben",
                hat = false,
                glasses = true,
                male = true,
                hairColor = "Black",
                facialHair = false,
                eyeColor = "Green",
                earrings = false,
            };
            Characters Lucas = new Characters()
            {
                name = "Lucas",
                hat = false,
                glasses = false,
                male = true,
                hairColor = "Brown",
                facialHair = true,
                eyeColor = "Blue",
                earrings = false,
            };
            Characters Mason = new Characters()
            {
                name = "Mason",
                hat = false,
                glasses = true,
                male = true,
                hairColor = "Red",
                facialHair = true,
                eyeColor = "Brown",
                earrings = false,
            };
            Characters Ethan = new Characters()
            {
                name = "Ethan",
                hat = false,
                glasses = false,
                male = true,
                hairColor = "Black",
                facialHair = false,
                eyeColor = "Green",
                earrings = false,
            };
            Characters Alexander = new Characters()
            {
                name = "Alexander",
                hat = false,
                glasses = true,
                male = true,
                hairColor = "Blonde",
                facialHair = true,
                eyeColor = "Blue",
                earrings = false,
            };
            Characters Henry = new Characters()
            {
                name = "Henry",
                hat = false,
                glasses = false,
                male = true,
                hairColor = "Brown",
                facialHair = true,
                eyeColor = "Brown",
                earrings = false,
            };
            Characters Olivia = new Characters()
            {
                name = "Olivia",
                hat = true,
                glasses = false,
                male = false,
                hairColor = "Blonde",
                facialHair = false,
                eyeColor = "Green",
                earrings = true,
            };
            Characters Emma = new Characters()
            {
                name = "Emma",
                hat = true,
                glasses = true,
                male = false,
                hairColor = "Red",
                facialHair = false,
                eyeColor = "Blue",
                earrings = false,
            };
            Characters Ava = new Characters()
            {
                name = "Ava",
                hat = true,
                glasses = true,
                male = false,
                hairColor = "Brown",
                facialHair = false,
                eyeColor = "Brown",
                earrings = true,
            };
            Characters Sophia = new Characters()
            {
                name = "Sophia",
                hat = true,
                glasses = false,
                male = false,
                hairColor = "Black",
                facialHair = false,
                eyeColor = "Green",
                earrings = true,
            };
            Characters Isabella = new Characters()
            {
                name = "Isabella",
                hat = true,
                glasses = true,
                male = false,
                hairColor = "Black",
                facialHair = false,
                eyeColor = "Blue",
                earrings = false,
            };
            Characters Charlotte = new Characters()
            {
                name = "Charlotte",
                hat = true,
                glasses = false,
                male = false,
                hairColor = "Red",
                facialHair = false,
                eyeColor = "Brown",
                earrings = false,
            };
            Characters Amelia = new Characters()
            {
                name = "Amelia",
                hat = false,
                glasses = true,
                male = false,
                hairColor = "Blonde",
                facialHair = false,
                eyeColor = "Green",
                earrings = true,
            };
            Characters Mia = new Characters()
            {
                name = "Mia",
                hat = false,
                glasses = true,
                male = false,
                hairColor = "Brown",
                facialHair = false,
                eyeColor = "Blue",
                earrings = false,
            };
            Characters Harper = new Characters()
            {
                name = "Harper",
                hat = false,
                glasses = true,
                male = false,
                hairColor = "Brown",
                facialHair = false,
                eyeColor = "brown",
                earrings = true,
            };
            Characters Evelyn = new Characters()
            {
                name = "Evelyn",
                hat = false,
                glasses = false,
                male = false,
                hairColor = "Black",
                facialHair = false,
                eyeColor = "Green",
                earrings = false,
            };
            Characters Abigail = new Characters()
            {
                name = "Abigail",
                hat = false,
                glasses = true,
                male = false,
                hairColor = "Red",
                facialHair = false,
                eyeColor = "Blue",
                earrings = false,
            };
            Characters Emily = new Characters()
            {
                name = "Emily",
                hat = false,
                glasses = false,
                male = false,
                hairColor = "Blonde",
                facialHair = false,
                eyeColor = "Brown",
                earrings = true,
            };

            List<Characters> listOfCharacters = new List<Characters>();
            listOfCharacters.Add(Liam);
            listOfCharacters.Add(Noah);
            listOfCharacters.Add(Oliver);
            listOfCharacters.Add(William);
            listOfCharacters.Add(Elijah);
            listOfCharacters.Add(James);
            listOfCharacters.Add(Ben);
            listOfCharacters.Add(Lucas);
            listOfCharacters.Add(Mason);
            listOfCharacters.Add(Ethan);
            listOfCharacters.Add(Alexander);
            listOfCharacters.Add(Henry);
            listOfCharacters.Add(Olivia);
            listOfCharacters.Add(Emma);
            listOfCharacters.Add(Ava);
            listOfCharacters.Add(Sophia);
            listOfCharacters.Add(Isabella);
            listOfCharacters.Add(Charlotte);
            listOfCharacters.Add(Amelia);
            listOfCharacters.Add(Mia);
            listOfCharacters.Add(Harper);
            listOfCharacters.Add(Evelyn);
            listOfCharacters.Add(Abigail);
            listOfCharacters.Add(Emily);
            List<Characters> playerBoard = listOfCharacters;
            List<Characters> computerBoard = listOfCharacters;
            Characters pc = listOfCharacters[randomNumber()];
            Characters cc = listOfCharacters[randomNumber()];

            while (true)
            {
                displayPlayerBoard(playerBoard);
                questions();
                string response = Console.ReadLine();
                playerBoard = evalResponse(response, cc, playerBoard);
                if (playerBoard.Count() == 1)
                {
                    Console.WriteLine($"Player guessed {cc.name} or only has one character left on the board! Player Wins!!!");
                    break;
                }
                else if (computerBoard.Count() == 1)
                {
                    Console.WriteLine($"Computer guessed {pc.name} or only has one character left on the board! Computer Wins!!!");
                    break;
                }
                //playerCharacter(pc);
                string computerResponse = randomQuestion().ToString();
                Console.WriteLine($"Computers question {computerResponse}");
                computerBoard = evalResponse(computerResponse, pc, computerBoard);
                Console.WriteLine($"How many characters the Player's board has left: {playerBoard.Count()}");
                Console.WriteLine($"How many characters the Computer's board has left: {computerBoard.Count()}");
            }
        }
        static int randomQuestion()
        {
            Random r = new Random();
            int computerQuestion = r.Next(0, 12);
            return computerQuestion;
        }
        static void displayPlayerBoard(List<Characters> x)
        {
            foreach (var pc in x)
            {
                Console.WriteLine($@" {pc.name}
                male: {pc.male}
                Hat: {pc.hat}
                Glasses: {pc.glasses}
                Earrings: {pc.earrings}
                Facial Hair: {pc.facialHair}
                Hair Color: {pc.hairColor}
                Eye Color: {pc.eyeColor}
                ");
            }
        }
        static void playerCharacter(Characters pc)
        {
            Console.WriteLine($@"Player's Character: {pc.name}
                male: {pc.male}
                Hat: {pc.hat}
                Glasses: {pc.glasses}
                Earrings: {pc.earrings}
                Facial Hair: {pc.facialHair}
                Hair Color: {pc.hairColor}
                Eye Color: {pc.eyeColor}
                ");
        }
        static int randomNumber()
        {
            Random r = new Random();
            int random = r.Next(0, 24);
            return random;
        }
        static void questions()
        {
            Console.WriteLine(@"Ask a question.
            1). Is your character male?
            2). Does your character have glasses?
            3). Does your character have a hat?
            4). Does your character have Facial hair?
            5). Does your character have earrings?
            6). Does your character have blue eyes?
            7). Does your character have brown eyes?
            8). Does your character have green eyes?
            9). Does your character have red hair?
            10). Does your character have blonde hair?
            11). Does your character have black hair?
            12). Does your character have brown hair?
            13). Guess Character!");
        }
        static List<Characters> evalResponse(string evalResponse, Characters cc, List<Characters> playerBoard)
        {
            if (evalResponse == "1")
            {
                if (cc.male == true)
                {
                    Console.WriteLine("Yes, My character is male.");
                    return playerBoard.Where(e => e.male == true).ToList();
                }
                else
                {
                    Console.WriteLine("No, My character is not male.");
                    return playerBoard.Where(e => e.male != true).ToList();
                }
            }
            else if (evalResponse == "2")
            {
                if (cc.glasses == true)
                {
                    Console.WriteLine("Yes, My character has glasses.");
                    return playerBoard.Where(e => e.glasses == true).ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have glasses.");
                    return playerBoard.Where(e => e.glasses != true).ToList();

                }
            }
            else if (evalResponse == "3")
            {
                if (cc.hat == true)
                {
                    Console.WriteLine("Yes, My character has a hat.");
                    return playerBoard.Where(e => e.hat == true).ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have a hat.");
                    return playerBoard.Where(e => e.hat != true).ToList();

                }
            }
            else if (evalResponse == "4")
            {
                if (cc.facialHair == true)
                {
                    Console.WriteLine("Yes, My character has facial hair.");
                    return playerBoard.Where(e => e.facialHair == true).ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have facial hair.");
                    return playerBoard.Where(e => e.facialHair != true).ToList();

                }
            }
            else if (evalResponse == "5")
            {
                if (cc.earrings == true)
                {
                    Console.WriteLine("Yes, My character has earrings.");
                    return playerBoard.Where(e => e.earrings == true).ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have earrings.");
                    return playerBoard.Where(e => e.earrings != true).ToList();

                }
            }
            else if (evalResponse == "6")
            {
                if (cc.eyeColor == "Blue")
                {
                    Console.WriteLine("Yes, My character has blue eyes.");
                    return playerBoard.Where(e => e.eyeColor == "Blue").ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have blue eyes.");
                    return playerBoard.Where(e => e.eyeColor != "Blue").ToList();

                }
            }
            else if (evalResponse == "7")
            {
                if (cc.eyeColor == "Brown")
                {
                    Console.WriteLine("Yes, My character has brown eyes.");
                    return playerBoard.Where(e => e.eyeColor == "Brown").ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have brown eyes.");
                    return playerBoard.Where(e => e.eyeColor != "Brown").ToList();

                }
            }
            else if (evalResponse == "8")
            {
                if (cc.eyeColor == "Green")
                {
                    Console.WriteLine("Yes, My character has green eyes.");
                    return playerBoard.Where(e => e.eyeColor == "Green").ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have green eyes.");
                    return playerBoard.Where(e => e.eyeColor != "Green").ToList();

                }
            }
            else if (evalResponse == "9")
            {
                if (cc.hairColor == "Red")
                {
                    Console.WriteLine("Yes, My character has red hair.");
                    return playerBoard.Where(e => e.hairColor == "Red").ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have red hair.");
                    return playerBoard.Where(e => e.hairColor != "Red").ToList();

                }
            }
            else if (evalResponse == "10")
            {
                if (cc.hairColor == "Blonde")
                {
                    Console.WriteLine("Yes, My character has blonde hair.");
                    return playerBoard.Where(e => e.hairColor == "Blonde").ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have blonde hair.");
                    return playerBoard.Where(e => e.hairColor != "Blonde").ToList();

                }
            }
            else if (evalResponse == "11")
            {
                if (cc.hairColor == "Black")
                {
                    Console.WriteLine("Yes, My character has black hair.");
                    return playerBoard.Where(e => e.hairColor == "Black").ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have black hair.");
                    return playerBoard.Where(e => e.hairColor != "Black").ToList();

                }
            }
            else if (evalResponse == "12")
            {
                if (cc.hairColor == "Brown")
                {
                    Console.WriteLine("Yes, My character has brown hair.");
                    return playerBoard.Where(e => e.hairColor == "Brown").ToList();
                }
                else
                {
                    Console.WriteLine("No, My character does not have brown hair.");
                    return playerBoard.Where(e => e.hairColor != "Brown").ToList();

                }
            }
            else if (evalResponse == "13")
            {
                Console.WriteLine("Who do you guess?");
                string x = Console.ReadLine();
                if (cc.name.ToLower() == x.ToLower())
                {
                    Console.WriteLine($"Yes, My character is {x}!");
                    return playerBoard.Where(e => e.name.ToLower() == x.ToLower()).ToList();
                }
                else
                {
                    Console.WriteLine($"No, My character is not {x}.");
                    return playerBoard.Where(e => e.name.ToLower() != x.ToLower()).ToList();

                }
            }
            else
            {
                questions();
                return playerBoard;
            }
        }
    }
}
