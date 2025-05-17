using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class Journal
{
    Entry entry = new Entry();
    string _question;
    string _response;
    int _title;
    Dictionary<int, List<string>> journal = new();


    public void Menu()
    {
        string choice = "";
        while (choice != "6")
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
                    Console.WriteLine("Please enter a title for your entry:");
                    _title = int.Parse(Console.ReadLine());
                    _question = entry.Questions();
                    _response = AddEntry(_question);
                    
                    break;
                case "2":
                    ShowEntries();
                    break;
                case "3":
                    SaveJournal(_response, _question, _title);
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

    public void SaveJournal(string _response, string _question, int _title)
    {
        Dictionary<int, List<string>> journal = new();

        if (File.Exists("journal.json"))
        {
            string json = File.ReadAllText("journal.json");
            journal = JsonSerializer.Deserialize<Dictionary<int, List<string>>>(json);
        }

        // Add the stored data
        journal[_title] = new List<string> { _question, _response };


        // Save it
        string output = JsonSerializer.Serialize(journal, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("journal.json", output);

        Console.WriteLine("Entry saved.");
    }
    public void ShowEntries()
    {
        if (File.Exists("journal.json"))
        {
            string json = File.ReadAllText("journal.json");
            Dictionary<int, List<string>> journal = JsonSerializer.Deserialize<Dictionary<int, List<string>>>(json);

            foreach (var entry in journal)
            {
                Console.WriteLine($"Title: {entry.Key}");
                Console.WriteLine($"Question: {entry.Value[0]}");
                Console.WriteLine($"Response: {entry.Value[1]}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No entries found.");
        }
    }
}
    