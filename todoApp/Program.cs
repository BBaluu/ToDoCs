using System;
using System.Collections.Generic;
using todoApp;

namespace todoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaskItem> todoList = new List<TaskItem>();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n--- To-Do Menu ---");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Edit Task");
                Console.WriteLine("4. View Tasks");
                Console.WriteLine("5. Save & Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": addTask(); break;
                    case "2": removeTask(); break;
                    case "3": editTask(); break;
                    case "4": listTasks(); break;
                    case "5": isRunning = false; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }

            void addTask()
            {
                Console.WriteLine("Enter the task to add:");
                string taskToAdd = Console.ReadLine();
                todoList.Add(new TaskItem(taskToAdd));
                Console.WriteLine("Task added!");
            }

            void removeTask()
            {
                listTasks();
                Console.WriteLine("Enter the number of the task to remove:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int index) && index >= 0 && index < todoList.Count)
                {
                    todoList.RemoveAt(index);
                    Console.WriteLine("Task removed!");
                }
                else
                {
                    Console.WriteLine("Invalid index.");
                }
            }

            void editTask()
            {
                listTasks();
                Console.WriteLine("Enter the number of the task you'd like to edit:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int index) && index >= 0 && index < todoList.Count)
                {
                    Console.WriteLine("Enter the new text for the task:");
                    string newText = Console.ReadLine();
                    todoList[index] = new TaskItem(newText);
                    Console.WriteLine("Task updated!");
                }
                else
                {
                    Console.WriteLine("Invalid index.");
                }
            }

            void listTasks()
            {
                if (todoList.Count == 0)
                {
                    Console.WriteLine("No tasks yet.");
                }
                else
                {
                    Console.WriteLine("\n--- To-Do List ---");
                    for (int i = 0; i < todoList.Count; i++)
                    {
                        Console.WriteLine($"{i+1}: {todoList[i]}");
                    }
                }
            }
        }
    }
}
