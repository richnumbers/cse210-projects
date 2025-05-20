using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class Entry
{
    public int _title;
    public string _question;
    public string _response;
    Random random = new Random();
    
  
    public string Questions()
    {


        List<string> questions = new List<string>
        {
            "What was the best part of your day?",
            "What was the worst part of your day?",
            "What did you learn today?",
            "What are you grateful for?",
            "Who did you talk to today?",
            "What was the most challenging part of your day?"
        };
        if (File.Exists("custom_questions.json"))
        {
            string json = File.ReadAllText("custom_questions.json");
            List<string> extras = JsonSerializer.Deserialize<List<string>>(json);
            questions.AddRange(extras); // ✅ Adds them to your main list
        }
        int count = questions.Count;
        int randomnumber = random.Next(0, count);


        return _question = questions[randomnumber];




    }

    public void AddQuestion()
{
    Console.Write("Enter your new question: ");
    string newQuestion = Console.ReadLine();

    List<string> questions = new List<string>();
    Console.WriteLine("Saving to: " + Path.GetFullPath("questions.json"));

    if (File.Exists("custom_questions.json"))
        {
            string json = File.ReadAllText("custom_questions.json");
            questions = JsonSerializer.Deserialize<List<string>>(json);
        }

    questions.Add(newQuestion);

    string updated = JsonSerializer.Serialize(questions, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText("custom_questions.json", updated);

    Console.WriteLine("custom_questions added.");
}


   
    
}
       