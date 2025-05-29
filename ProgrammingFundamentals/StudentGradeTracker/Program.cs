var studentScores = new Dictionary<string, List<int>>();

while (true)
{
    Console.Write("Enter student name (or type 'done' to finish): ");
    var name = Console.ReadLine();

    if (name.ToLower() == "done")
        break;

    var scores = new List<int>();
    Console.WriteLine($"Enter 5 scores for {name}:");

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Score {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out int scoreInput))
            scores.Add(scoreInput);
        else
        {
            Console.WriteLine("Invalid input. Try again.");
            i--; 
        }
    }

    studentScores[name] = scores;
    Console.Clear();
}

Console.WriteLine("\n--- Student Results ---\n");

foreach (var (student, scores) in studentScores)
{
    Console.WriteLine($"Student Name: {student}");
    Console.WriteLine("Scores: ");
    foreach (var score in scores)
    {
        Console.WriteLine($"- {score}");
    }

    double average = scores.Average();
    Console.WriteLine($"Average Score: {average}\n");
}
