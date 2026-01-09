using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
#region Task 1
//namespace Lab7
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            string fileName = "data.txt";

//            Console.Write("Enter: ");
//            string name = Console.ReadLine();

//            File.WriteAllText(fileName, name);

//            string textFromFile = File.ReadAllText(fileName);

//            Console.WriteLine("--------------");
//            Console.WriteLine(textFromFile);

//        }

//    }
//}
#endregion

#region Task 2
//namespace Lab7
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string filePath = "data.txt";
//            List<string> lines = new List<string>();
//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write("Enter text: ");
//                string input = Console.ReadLine();
//                lines.Add(input);
//            }

//            File.WriteAllLines(filePath, lines);
//            string[] linesFromFile = File.ReadAllLines(filePath);
//            Console.WriteLine("---------------------------------------");
//            Console.WriteLine($"Number of lines in the file: {linesFromFile.Length}");       

//            foreach (string line in linesFromFile)
//            {
//                Console.WriteLine(line);
//            }

//        }
//    }
//}
#endregion

#region Task 3
//namespace Lab7
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            string filePath = "data.txt";


//            if (!File.Exists(filePath))
//            {
//                Console.WriteLine("Not File");
//                return;
//            }

//            string[] lines = File.ReadAllLines(filePath);
//            Console.WriteLine("---------------------------------------");

//            Console.WriteLine($"Enter text");
//            foreach (string line in lines)
//            {
//                {
//                    Console.WriteLine(line.ToUpper());
//                }
//            }
//            int count = 0;
//            foreach (string line in lines)
//            {
//                string lowerLine = line.ToLower();
//                int index = 0;

//                while ((index = lowerLine.IndexOf("hello", index)) != -1)
//                {
//                    count++;
//                    index += "hello".Length;
//                }
//            }

//            Console.WriteLine($"\n\"salam\" sözü {count} dəfə keçib.");
//        }
//    }
//}
#endregion

#region Task 4
//namespace Lab7
//{
//    internal class Program
//    {
//        static string filePath = "todolist.txt";
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.Clear();
//                Console.Clear();
//                Console.WriteLine("=== TODO LIST ===");
//                Console.WriteLine("1. Add task");
//                Console.WriteLine("2. View all");
//                Console.WriteLine("3. Search");
//                Console.WriteLine("0. Exit");
//                Console.Write("Choose: ");

//                string choice = Console.ReadLine();

//                if (choice == "1") AddTask();
//                else if (choice == "2") ViewAll();
//                else if (choice == "3") Search();
//                else if (choice == "0") break;
//                else
//                {
//                    Console.WriteLine("Wrong choice!");
//                    Pause();
//                }
//            }
//        }

//        static void AddTask()
//        {
//            Console.Clear();
//            Console.Write("Enter task:");
//            string task = Console.ReadLine();

//            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
//            string line = $"{time} - {task}";

//            File.AppendAllText(filePath, line + Environment.NewLine);

//            Console.WriteLine("Saved");
//            Pause();
//        }

//        static void ViewAll()
//        {
//            Console.Clear();

//            if (!File.Exists(filePath))
//            {
//                Console.WriteLine("No tasks yet.");
//                Pause();
//                return;
//            }

//            string[] lines = File.ReadAllLines(filePath);

//            Console.WriteLine("All tasks:");
//            foreach (var line in lines)
//                Console.WriteLine(line);

//            Pause();
//        }

//        static void Search()
//        {
//            Console.Clear();

//            if (!File.Exists(filePath))
//            {
//                Console.WriteLine("File not found");
//                Pause();
//                return;
//            }

//            Console.Write("Search word:");
//            string word = Console.ReadLine().ToLower();

//            string[] lines = File.ReadAllLines(filePath);
//            bool found = false;

//            Console.WriteLine("Results:");

//            foreach (var line in lines)
//            {
//                if (line.ToLower().Contains(word))
//                {
//                    Console.WriteLine(line);
//                    found = true;
//                }
//            }

//            if (!found)
//                Console.WriteLine("Nothing found.");

//            Pause();
//        }

//        static void Pause()
//        {
//            Console.WriteLine("Press Enter..");
//            Console.ReadLine();
//        }
//    }
//}
#endregion

#region Task 5

//string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GameInfo");
//Directory.CreateDirectory(basePath);

//string recordFile = Path.Combine(basePath, "history.txt");
//string bestScoreFile = Path.Combine(basePath, "best_score.txt");

//Console.Write("Enter your name: ");
//string playerName = Console.ReadLine();

//Random rnd = new Random();
//int secretNumber = rnd.Next(1, 101);
//int attempts = 0;
//int guess = 0;

//Console.WriteLine("Guess the number between 1 and 100!");

//while (guess != secretNumber)
//{
//    Console.Write("Guess: ");
//    string input = Console.ReadLine();

//    if (!int.TryParse(input, out guess))
//    {
//        Console.WriteLine("Error! Please enter a number.");
//        continue;
//    }

//    attempts++;

//    if (guess < secretNumber)
//        Console.WriteLine("Higher!");
//    else if (guess > secretNumber)
//        Console.WriteLine("Lower!");
//}

//Console.WriteLine($"Congratulations! You found it in {attempts} attempts.");

//string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

//string logEntry = $"{playerName} | {attempts} | {dateTime}";
//File.AppendAllText(recordFile, logEntry + Environment.NewLine);

//int currentBestScore = int.MaxValue;

//if (File.Exists(bestScoreFile))
//{
//    string bestData = File.ReadAllText(bestScoreFile);
//    if (!string.IsNullOrWhiteSpace(bestData))
//    {
//        string[] parts = bestData.Split('|');
//        if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int savedScore))
//        {
//            currentBestScore = savedScore;
//        }
//    }
//}

//if (attempts < currentBestScore)
//{
//    File.WriteAllText(bestScoreFile, logEntry);
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("NEW BEST SCORE! Saved.");
//    Console.ResetColor();
//}
//else
//{
//    Console.WriteLine($"Best score remains: {currentBestScore}");
//}
#endregion