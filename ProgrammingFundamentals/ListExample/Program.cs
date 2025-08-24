// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> shoppingList = new List<string>
{
    "Chocolate",
    "Ice-cream",
    "Chips",
    "Cookies",
    "Soda"
};
shoppingList.Add("Fruits");
shoppingList.Sort();
string userInput;
while (shoppingList.Count != 0)
{
    Console.WriteLine("This is your List: ");
    foreach (var item in shoppingList)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("Enter your Item: ");
    userInput = Console.ReadLine();
    if (shoppingList.Contains(userInput))
        shoppingList.Remove(userInput);
    else
        shoppingList.Add(userInput);
    Console.Clear();
}
