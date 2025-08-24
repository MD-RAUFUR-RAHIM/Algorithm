using System.Xml.Linq;

var studentGrades = new Dictionary<string, List<int>>();
while (true) {
    Console.WriteLine("Enter Student name: (Type done to finish)");
    var name = Console.ReadLine().Trim();
    if (name.ToLower() == "done")
        break;
    var grades = new List<int>();
    Console.Write("How many grades for this student? ");
    if ((int.TryParse(Console.ReadLine(), out int count)))
    {
        for(int i= 0; i<count; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int grade))
                grades.Add(grade);
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                i--;
            }
        }
    }
   
    studentGrades[name] = grades;
    Console.Clear();
}

var studentAverages = studentGrades.ToDictionary(
    pair => pair.Key,
    pair => pair.Value.Average()
    );

var sortedStudents = studentAverages
    .OrderByDescending(kvp => kvp.Value)
    .Select(kvp => kvp.Key)
    .ToList();

foreach (var (name, grades) in studentGrades)
{
    var avg = studentAverages[name];

    Console.WriteLine($"\nStudent: {name}");
    Console.WriteLine("Grades: " + string.Join(", ", grades));
    Console.WriteLine($"Average Grade: {avg:F2}");

    int rank = sortedStudents.IndexOf(name) + 1;
    Console.WriteLine($"Rank: {rank}");
}