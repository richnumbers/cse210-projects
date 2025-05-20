using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class Journal
{
    Entry entry = new Entry();
    List<Entry> entries = new List<Entry>();
    string Question;
    string Response;
    int Title;
    Dictionary<int, List<string>> journal = new();
    


    public void Menu()
    {
        if (File.Exists("journal.json"))
{
        string json = File.ReadAllText("journal.json");
        entries = JsonSerializer.Deserialize<List<Entry>>(json);
}
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal App!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Show Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Add Question");
            Console.WriteLine("5. Exit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter the Data: mmddyyyy for your entry:");
                    Title = int.Parse(Console.ReadLine());
                    Question = entry.Questions();
                    Response = AddEntry(Question);
                    entries.Add(new Entry { _title = Title, _question = Question, _response = Response });


                    break;
                case "2":
                    ShowEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    entry.AddQuestion();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

    }

    public string AddEntry(string _question)
    {

        Console.WriteLine(_question);
        Console.WriteLine("Please enter your response:");
        string _response = Console.ReadLine();

        return _response;

    }

   public void SaveJournal()
{
    string json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText("journal.json", json);
    Console.WriteLine("All entries saved.");
}   public void ShowEntries()
{
    if (entries.Count == 0)
    {
        Console.WriteLine("No entries found.");
        return;
    }

    foreach (var e in entries)
    {
        Console.WriteLine($"Title: {e._title}");
        Console.WriteLine($"Question: {e._question}");
        Console.WriteLine($"Response: {e._response}");
        Console.WriteLine();
    }
}
}
    