// To do list app
Console.WriteLine("Welcome in to do list app!");

List<string> listToDo = new List<string>();
String userOption = "";
String userTask = "";

try
{
    do
    {
        Console.WriteLine("What you want to do?(to choose enter action number.");
        Console.WriteLine("1. Add task to list");
        Console.WriteLine("2. Print all tasks in list");
        Console.WriteLine("3. Remove task from list");
        Console.WriteLine("Enter \"4\" to close app.");
        Console.Write("Choose action: ");

        userOption = Console.ReadLine();

        switch (userOption)
        {
            case "1":
                {
                    Console.Write("Write task to do: ");
                    userTask = Console.ReadLine();
                    listToDo.Add(userTask);
                }; break;
            case "2":
                {
                    int taskNumber = 1;
                    for (int i = 0; i < listToDo.Count; i++)
                    {
                        Console.WriteLine(taskNumber + ". " + listToDo[i]);
                        taskNumber++;
                    }
                    if (taskNumber == 1) {
                        Console.WriteLine("List is empty!");
                    }
                }; break;
            case "3":
                {
                    Console.Write("\nEnter number of task to remove it from task list.\n");
                    int taskNumber = 1;
                    for (int i = 0; i < listToDo.Count; i++)
                    {
                        Console.WriteLine(taskNumber + ". " + listToDo[i]);
                        taskNumber++;
                    }
                    if (taskNumber == 1)
                    {
                        Console.WriteLine("List is empty!\n");
                    }else{
                        Console.Write("Remove: ");
                        int taskToRemove = Convert.ToInt32(Console.ReadLine());
                        listToDo.RemoveAt(taskToRemove - 1);
                    }
                    }; break;
            case "4": Console.WriteLine("App is closed."); ; break;
            default: Console.WriteLine("Wrong data!"); break;
        }
    } while (userOption != "4");
}
catch (Exception ex) {
    Console.WriteLine(ex);
}
