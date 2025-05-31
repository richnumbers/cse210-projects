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
        Memorized(editedList,OrginalList, Refs, list);
        
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
            trying.CheckVers(checking, orginal);
            _input = Console.ReadLine();
         

            if (_input.ToLower() == "quite")
            {
                break;
            }
            
            i++;



        }
    }
    

}