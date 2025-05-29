var library = new Dictionary<string, List<string>>();

while (true)
{
    Console.WriteLine("Enter a genre (Type done to finish)");
    var name = Console.ReadLine().Trim();
    if (name.ToLower() == "done")
        break;
    var books = new List<string>();
    Console.Write("How many books for this genre? ");
    if (int.TryParse(Console.ReadLine(), out int count))
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Book {i + 1}: ");
            books.Add(Console.ReadLine());
        }
    }
    library[name]= books;
    Console.Clear();
}
foreach (var (genre, book) in library)
{
    Console.WriteLine("\nGenre: " + genre);
    foreach (var item in book)
    {
        Console.WriteLine("Book Name: " + item);
    }
}