using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();

            while (true)
            {
                Console.WriteLine("Todo List Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Remove a task");
                Console.WriteLine("5. EXIT");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the task to add: ");
                        string newTask = Console.ReadLine();
                        todoList.Add(newTask);
                        Console.WriteLine("Task added successfully.");
                        break;
                    case 2:
                        Console.WriteLine("Todo List:");
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }
                        break;
                    case 3:
                        Console.Write("Enter the task number to mark as completed: ");
                        int taskNumber;
                        if (!int.TryParse(Console.ReadLine(), out taskNumber) || taskNumber < 1 || taskNumber > todoList.Count)
                        {
                            Console.WriteLine("Invalid task number. Please enter a valid task number.");
                            continue;
                        }
                        todoList.RemoveAt(taskNumber - 1);
                        Console.WriteLine("Task marked as completed.");
                        break;
                    case 4:
                        Console.Write("Enter the task number to remove: ");
                        int removeTaskNumber;
                        if (!int.TryParse(Console.ReadLine(), out removeTaskNumber) || removeTaskNumber < 1 || removeTaskNumber > todoList.Count)
                        {
                            Console.WriteLine("Invalid task number. Please enter a valid task number.");
                            continue;
                        }
                        todoList.RemoveAt(removeTaskNumber - 1);
                        Console.WriteLine("Task removed successfully.");
                        break;
                    case 5:
                        Console.WriteLine("Exiting program. Goodbye");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid choice.");
                        break;
                }
            }

        }
    }

}
