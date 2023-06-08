Console.WriteLine(" well come to do tasks,");
Console.WriteLine("");
List<string> tasks = new List<string>();
bool state = false;
while (!state)
{
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove a task");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice (1-4):");
    Console.WriteLine();
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.Write("Enter the task ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully");
            break;

        case "2":
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found,it is Empty");
            }
            else
            {
                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {

                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
                Console.WriteLine("");
            }
            break;
        case "3":
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found,it is Empty");
            }
            else
            {
                Console.Write("Enter the task number to remove it: ");
                int taskNumber;

                if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
                {
                    string removedTask = tasks[taskNumber - 1];
                    tasks.RemoveAt(taskNumber - 1);
                    Console.WriteLine($"Task '{removedTask}' removed successfully!");
                }
                else
                {
                    Console.WriteLine("Error task number, Please try again.");
                }
            }
            break;
        case "4":
            state = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}