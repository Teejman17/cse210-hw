using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string selection = "";
        while (selection != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the above menu: ");
            selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("THank you, goodbye.");
                    break;

            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to make? ");
        string selection = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the descritption of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points for this goal? ");
        string points = Console.ReadLine();

        Goal newGoal = null;
        switch (selection)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be completed for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for completing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you complete? ");
        int completedGoal = int.Parse(Console.ReadLine()) - 1;

        if (completedGoal >= 0 && completedGoal < _goals.Count)
        {
            Goal goal = _goals[completedGoal];
            int pointsEarned = 0;

            if (goal.IsComplete())
            {
                Console.WriteLine("The goal is completed.");
                return;
            }
            goal.RecordEvent();

            if (goal is SimpleGoal)
            {
                pointsEarned = int.Parse(goal.GetPoints());
            }
            else if (goal is EternalGoal)
            {
                pointsEarned = int.Parse(goal.GetPoints());
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                pointsEarned = int.Parse(goal.GetPoints());
                if (checklistGoal.IsComplete())
                {
                    pointsEarned = checklistGoal.GetBonus();
                }
            }
            {
                goal.RecordEvent();
                pointsEarned = int.Parse(goal.GetPoints());
                _score += pointsEarned;

                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points");
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter savedFile = new StreamWriter(filename))
        {
            savedFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                savedFile.WriteLine(goal.GetDetailsString());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(data[0], data[1], data[2], bool.Parse(data[3])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], data[2]));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(data[0], data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
                    break;
            }

            }

        }
    }
