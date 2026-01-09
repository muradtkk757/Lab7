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




#endregion