using System.Buffers.Binary;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



public class Words
{
    private Random random = new Random();
    private bool _hidden;
    private string _word;

    private List<Words> _truewords = new List<Words>();



    private Words(string word)
    {
        _word = word;
        _hidden = false;

    }
    public Words(List<string> word)
    {
        foreach (var w in word)
        {
            Words words = new Words(w);
            _truewords.Add(words);
        }

    }


    public List<Words> GetWords()
    {
        return _truewords;
    }

    public string GetDisplay()
    {
        return _word;
    }

    public void HideWord(List<Words> words)
    {

        string w = "";
        int n = words.Count;
        int k = random.Next(n--);
        if (words[k]._hidden == true)
        {
            HideWord(words);
        }
        else
        {
            words[k]._hidden = true;
            int a = words[k]._word.Length;
            for (int i = 0; i < a; i++)
            {
                w += "_";

            }
            words[k]._word = w;
        }


    }

    public void CheckVers(List<Words> w1, List<Words> w2)
    {
        int i = 0;
        int RightWords = 0;
        int wrrongWords = 0;
        while (i < w2.Count)
        {
            if (w1.Count == w2.Count)
            {
                if (w1[i]._word.ToLower() != w2[i]._word.ToLower())
                {
                    wrrongWords++;

                }
                else if (w1[i]._word.ToLower() == w2[i]._word.ToLower())
                {
                    RightWords++;
                }

            }
            else
            {
                Console.Write("The Scriputes lenght is not right");
                break;
            }
            i++;
        }
        Console.WriteLine($"You had {RightWords} words right, and {wrrongWords} wrong");
        

    }
}
