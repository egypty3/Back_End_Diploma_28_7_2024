



namespace Lect5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Task> tasks = new List<Task>();

			int nextId = 1;

			while (true)
			{
				Console.WriteLine("\n\nWelcome to the Todo List Application!");
				Console.WriteLine("Please select an option:");
				Console.WriteLine("1. Add Task");
				Console.WriteLine("2. View Tasks");
				Console.WriteLine("3. Update Task");
				Console.WriteLine("4. Delete Task");
				Console.WriteLine("5. Exit");
				Console.Write(">");

				string input = Console.ReadLine();

				switch (input)
				{
					case "1":
						// Add Task
						AddTask(tasks,ref nextId);
						break;
					case "2":
						// View Tasks
						ViewTasks(tasks);
						break;
					case "3":
						// Update Task
						UpdateTask(tasks);
						break;
					case "4":
						// Delete Task
						DeleteTask(tasks);
						break;
					case "5":
						Console.WriteLine("Exiting the application. GoodBye!");
						return ;
					default:
						Console.WriteLine("Invalid option. Please try again.");
						break;
				}

			}
		}

		private static void DeleteTask(List<Task> tasks)
		{
			Console.WriteLine("Enter the task ID to delete: ");

			int taskId = Convert.ToInt32(Console.ReadLine());

			Task task = tasks.Find(t => t.id == taskId);

			if (task != null)
			{
				tasks.Remove(task);
				Console.WriteLine("Task deleted successfully");

			}
			else
			{
				Console.WriteLine("Task not found");
			}
		}

		private static void UpdateTask(List<Task> tasks)
		{
			Console.WriteLine("Enter the task ID to update: ");
			
			int taskId = Convert.ToInt32(Console.ReadLine());
			
			Task task = tasks.Find( t => t.id == taskId);

			if ( task != null)
			{
				Console.WriteLine("Enter new description");
				task.description = Console.ReadLine();
				Console.WriteLine("Enter new status (true/false)");
				task.IsCompleted = bool.Parse( Console.ReadLine());
				Console.WriteLine("Task update successfully");

			}
			else
			{
				Console.WriteLine("Task not found");
			}

		}

		private static void ViewTasks(List<Task> tasks)
		{
			if (tasks.Count == 0)
			{
				Console.WriteLine("No tasks available");
				return;
			}

			for (int i = 0; i < tasks.Count; i++)
			{
				Console.WriteLine(
						$"ID: {tasks[i].id} | Description : {tasks[i].description} | Completed: {tasks[i].IsCompleted}"
					);
			}
		}

		private static void AddTask(List<Task> tasks,ref int nextId)
		{
			Console.Write("Enter task description: ");
			string description = Console.ReadLine();

			Task task = new Task();

			task.id = nextId;
			task.description = description;
			task.IsCompleted = false;

			tasks.Add(task);

			nextId++;

			Console.WriteLine("Task  added successfully.");
		}
	}
}
