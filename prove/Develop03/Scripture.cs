using System.Diagnostics;
using System.Runtime.InteropServices;

public class Scripture
{
    private Reference reference;
    private Words Words;
    private string _input = "";
    private int _i;

    public Scripture(Reference Refs, string SriputerWords)
    {

        List<string> word = SriputerWords.Split(' ').ToList();
        Words list = new Words(word);
        Words list2 = new Words(word);
        List<Words> editedList = list.GetWords();
        List<Words> OrginalList = list2.GetWords();

        Refs.GetFullReference();
        foreach (var item in editedList)
        {
            Console.Write(item.GetDisplay() + " ");
        }
        Memorized(editedList, OrginalList, Refs, list);

    }

    private void Memorized(List<Words> word, List<Words> orginal, Reference Refs, Words words)
    {



        int i = 0;
        _input = Console.ReadLine();

        while (i < word.Count)
        {
            Console.Clear();
            Refs.GetFullReference();
            words.HideWord(word);
            foreach (var item in word)
            {
                Console.Write(item.GetDisplay() + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Write the Scripture");
            _input = Console.ReadLine();
            if (_input.ToLower() == "quite")
            {
                break;
            }
            List<string> Starting = _input.Split(' ').ToList();
            Words trying = new Words(Starting);
            List<Words> checking = trying.GetWords();
            CheckVers(checking, orginal);
            _input = Console.ReadLine();


            if (_input.ToLower() == "quite")
            {
                break;
            }

            i++;



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
                if (w1[i].GetDisplay().ToLower() != w2[i].GetDisplay().ToLower())
                {
                    wrrongWords++;

                }
                else if (w1[i].GetDisplay().ToLower() == w2[i].GetDisplay().ToLower())
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