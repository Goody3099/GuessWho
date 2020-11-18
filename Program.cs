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
            Characters Liam = new Characters("Liam", true, true, true, "Red", false, "Green", false);
            Characters Noah = new Characters("Noah", true, false, true, "Blonde", true, "Blue", false);
            Characters Oliver = new Characters("Oliver", true, true, true, "Black", false, "Brown", false);
            Characters William = new Characters("William", true, false, true, "Brown", true, "Green", false);
            Characters Elijah = new Characters("Elijah", true, true, true, "Red", true, "Blue", false);
            Characters James = new Characters("James", true, false, true, "Blonde", false, "Brown", false);
            Characters Ben = new Characters("Ben", false, true, true, "Black", false, "Green", false);
            Characters Lucas = new Characters("Lucas", false, false, true, "Brown", true, "Blue", false);
            Characters Mason = new Characters("Mason", false, true, true, "Red", true, "Brown", false);
            Characters Ethan = new Characters("Ethan", false, false, true, "Black", false, "Green", false);
            Characters Alexander = new Characters("Alexander", false, true, true, "Blonde", true, "Blue", false);
            Characters Henry = new Characters("Henry", false, false, true, "Brown", true, "Brown", false);
            Characters Olivia = new Characters("Olivia", true, false, false, "Blonde", false, "Green", true);
            Characters Emma = new Characters("Emma", true, true, false, "Red", false, "Blue", false);
            Characters Ava = new Characters("Ava", true, true, false, "Brown", false, "Brown", true);
            Characters Sophia = new Characters("Sophia", true, false, false, "Black", false, "Green", true);
            Characters Isabella = new Characters("Isabella", true, true, false, "Black", false, "Blue", false);
            Characters Charlotte = new Characters("Charlotte", true, false, false, "Red", false, "Brown", false);
            Characters Amelia = new Characters("Amelia", false, true, false, "Blonde", false, "Green", true);
            Characters Mia = new Characters("Mia", false, true, false, "Brown", false, "Blue", false);
            Characters Harper = new Characters("Harper", false, true, false, "Brown", false, "Brown", true);
            Characters Evelyn = new Characters("Evelyn", false, false, false, "Black", false, "Green", false);
            Characters Abigail = new Characters("Abigail", false, true, false, "Red", false, "Blue", false);
            Characters Emily = new Characters("Emily", false, false, false, "Blonde", false, "Brown", true);

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
            List<string> playerQuestions = createQuestions();
            List<string> computerQuestions = createQuestions();

            while (true)
            {
                displayPlayerBoard(playerBoard);
                questions(playerQuestions);
                string response = Console.ReadLine();
                playerBoard = evalResponse(response, cc, playerBoard, playerQuestions);
                playerQuestions = newQuestions(Int32.Parse(response), playerQuestions);

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
                string computerResponse = randomQuestion(computerQuestions).ToString();
                Console.WriteLine($"Computers question {computerResponse}");
                computerBoard = evalResponse(computerResponse, pc, computerBoard, computerQuestions);
                computerQuestions = newQuestions(Int32.Parse(response), computerQuestions);
                Console.WriteLine($"How many characters the Player's board has left: {playerBoard.Count()}");
                Console.WriteLine($"How many characters the Computer's board has left: {computerBoard.Count()}");
            }
        }
        static List<string> newQuestions(int index, List<string> questions)
        {
            if (index != questions.Count())
            {
                questions.RemoveAt(index - 1);
                return questions;
            }
            return questions;
        }
        static int randomQuestion(List<string> x)
        {
            Random r = new Random();
            int computerQuestion = r.Next(0, x.Count() - 2);
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
        static int randomNumber()
        {
            Random r = new Random();
            int random = r.Next(0, 24);
            return random;
        }
        static void questions(List<string> questions)
        {
            int x = 0;
            while (x < questions.Count())
            {
                Console.WriteLine($"{x + 1}) {questions[x]}");
                x++;
            }
        }
        static List<string> createQuestions()
        {
            List<string> list = new List<string>()
            {
                "Is your character male?",
                "Does your character have glasses?",
                "Does your character have a hat?",
                "Does your character have Facial hair?",
                "Does your character have earrings ?",
                "Does your character have blue eyes?",
                "Does your character have brown eyes?",
                "Does your character have green eyes?",
                "Does your character have red hair?",
                "Does your character have blonde hair?",
                "Does your character have black hair?",
                "Does your character have brown hair?",
                "Guess Character!"
            };
            return list;
        }
        static List<Characters> evalResponse(string evalResponse, Characters cc, List<Characters> playerBoard, List<string> questions)
        {
            var q = questions[Int32.Parse(evalResponse) - 1];
            if (q == "Is your character male?")
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
            else if (q == "Does your character have glasses?")
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
            else if (q == "Does your character have a hat?")
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
            else if (q == "Does your character have Facial hair?")
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
            else if (q == "Does your character have earrings?")
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
            else if (q == "Does your character have blue eyes?")
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
            else if (q == "Does your character have brown eyes?")
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
            else if (q == "Does your character have green eyes?")
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
            else if (q == "Does your character have red hair?")
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
            else if (q == "Does your character have blonde hair?")
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
            else if (q == "Does your character have black hair?")
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
            else if (q == "Does your character have brown hair?")
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
            else if (q == "Guess Character!")
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
                //questions(questions);
                return playerBoard;
            }
        }
    }
}
