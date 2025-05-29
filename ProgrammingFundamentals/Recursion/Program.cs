using System.Reflection.PortableExecutable;

const string directoryPath = @"E:\MVC";
DisplayDirectories(directoryPath,2);
static void DisplayDirectories(string path, int depth = 0)
{
    string[] driectories = Directory.GetDirectories(path);
    foreach (var dir in driectories)
    {
        Console.WriteLine(dir);

        if (depth > 0)
        {
            DisplayDirectories(dir , depth - 1);  
        }
    }
 }

