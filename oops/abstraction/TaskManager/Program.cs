using System;
using System.Collections.Generic;

namespace TaskHandler{
//Abstract class for describing task
public abstract class Task {
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }
//Constructor for Task class
    public Task(string title, string description) {
        this.Title = title;
        this.Description = description;
        this.IsComplete = false;
    }
//abstract method for display
    public abstract void Display();

//complete method
    public void Complete() {
        this.IsComplete = true;
    }
}

//Assignment class intends Task class
public class Assignment : Task {
    //Assignment class fields
    public DateTime DueDate { get; set; }

    //Assignment class constructor
    public Assignment(string title, string description, DateTime dueDate) 
        : base(title, description) {
        this.DueDate = dueDate;
    }

    //implementation of abstract method
    public override void Display() {
        Console.WriteLine($"Assignment: {this.Title}");
        Console.WriteLine($"Description: {this.Description}");
        Console.WriteLine($"Due date: {this.DueDate.ToShortDateString()}");
        Console.WriteLine($"Status: {(this.IsComplete ? "Completed" : "Incomplete")}");
    }
}

//Reminder class intends Task class
public class Reminder : Task {
    public DateTime ReminderDate { get; set; }
//Reminder constructor to initialize field values
    public Reminder(string title, string description, DateTime reminderDate) 
        : base(title, description) {
        this.ReminderDate = reminderDate;
    }

//Implementation of abstract method
    public override void Display() {
        Console.WriteLine($"Reminder: {this.Title}");
        Console.WriteLine($"Description: {this.Description}");
        Console.WriteLine($"Reminder date: {this.ReminderDate.ToShortDateString()}");
        Console.WriteLine($"Status: {(this.IsComplete ? "Completed" : "Incomplete")}");
    }
}

//TaskManager class to track tasks
public class TaskManager {
    //List of class type task to store task objects
    private List<Task> tasks = new List<Task>();

    //Addtask method to add tasks on list
    public void AddTask(Task task) {
        tasks.Add(task);
    }

    //Complete task method with index based values
    public void CompleteTask(int index) {
        if(tasks.Count == 0){
            Console.WriteLine("No tasks has been scheduled....");
        }else{
        tasks[index].Complete();
        }
    }

    //Display method to show all tasks in the list
    public void DisplayTasks() {
        Console.WriteLine("Tasks:");
        Console.WriteLine("------");

        foreach (Task task in tasks) {
            task.Display();
            Console.WriteLine();
        }
    }
}

class Program {
    static void Main(string[] args) {

        TaskManager taskManager = new TaskManager();
        Console.WriteLine("*********************");
        Console.WriteLine("-----Task Manager-----");
        initial_label:
        Console.WriteLine(" 1.Add Task \n 2.Complete Task \n 3.Display Task");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option) {
        case 1:
        Console.WriteLine(" Select task type to add \n 1.Assignment \n 2.Remainder");
        int addOption = Convert.ToInt32(Console.ReadLine());
        switch(addOption){
            case 1:
                assignment_label:
                Console.WriteLine("Enter the title for assignment : ");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the description : ");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the due date : ");
                Console.WriteLine("year : ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("month : ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("date : ");
                int date = Convert.ToInt32(Console.ReadLine());
                Assignment newAssignment = new Assignment(title,description,new DateTime(year,month,date));
                taskManager.AddTask(newAssignment);
                Console.WriteLine("If you want to add another task press enter...");
                var assignmentInputValue = Console.ReadKey();
                if(assignmentInputValue.Key == ConsoleKey.Enter)
                    goto assignment_label;
                else if(assignmentInputValue.Key == ConsoleKey.Escape)
                    goto initial_label;

                break;

             case 2:
                reminder_label:
                Console.WriteLine("Enter the title for reminder : ");
                string assignmentTitle = Console.ReadLine();
                Console.WriteLine("Enter the description : ");
                string assignmentDescription = Console.ReadLine();
                Console.Write("Enter the due date : ");
                Console.WriteLine("year : ");
                int assignmentYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("month : ");
                int assignmentMonth = Convert.ToInt32(Console.ReadLine());
                int assignmentDate = Convert.ToInt32(Console.ReadLine());
                Reminder newReminder = new Reminder(assignmentTitle,assignmentDescription,new DateTime(assignmentYear,assignmentMonth,assignmentDate));
                taskManager.AddTask(newReminder);
                Console.WriteLine("If you want to add another task press enter or press esc to home..");
                var reminderInputValue = Console.ReadKey();
                if(reminderInputValue.Key == ConsoleKey.Enter)
                    goto reminder_label;
                else if(reminderInputValue.Key == ConsoleKey.Escape)
                    goto initial_label;
                break;
            }
            break;

            case 2:
                complete_label:
                Console.WriteLine("Enter the index to complete task:");
                int index = Convert.ToInt32(Console.ReadLine());
                taskManager.CompleteTask(index);
                Console.WriteLine("If you want to continue complete task press enter or press esc to home...");
                var completeInputValue = Console.ReadKey();
                if(completeInputValue.Key == ConsoleKey.Enter)
                    goto complete_label;
                else if(completeInputValue.Key == ConsoleKey.Escape)
                    goto initial_label;
                break;

            case 3:
                taskManager.DisplayTasks();
                Console.WriteLine("If you want to continue complete task press enter or press esc to exit..");
                var displayInputValue = Console.ReadKey();
                if(displayInputValue.Key == ConsoleKey.Enter)
                    goto initial_label;
                break;
        }

       
    }
}

}
