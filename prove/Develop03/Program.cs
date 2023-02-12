using System;
using System.Collections.Generic;

namespace ScriptureMastery2012
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture s = new Scripture();

            Display d = new Display(s.BOMList, null);
            HiddenWords h = new HiddenWords();
            while (true)
            {
                Console.WriteLine("\nPress Enter or type QUIT to end.");

                string resp = Console.ReadLine();
                if (resp == "quit")
                {
                    Console.Write("Thanks for Playing!");
                    break;
                }
                else if (resp == string.Empty)
                {
                    Console.Clear();
                    h.HideWords(s.BOMList.Count);
                    Display d1 = new Display(s.BOMList, h);
                }
            }
            
        }
    }


    public class Scripture
    {
        public static string[] BOM = {"And","now,","my","sons,","remember,","remember","that","it","is","upon","the","rock","of","our","Redeemer,","who","is","Christ,","the","Son","of","God,","that","ye","must","build","your","foundation;","that","when","the","devil","shall","send","forth","his","mighty","winds,","yea,","his","shafts","in","the","whirlwind,","yea,","when","all","his","hail","and","his","mighty","storm","shall","beat","upon","you,","it","shall","have","no","power","over","you","to","drag","you","down","to","the","gulf","of","misery","and","endless","wo,","because","of","the","rock","upon","which","ye","are","built,","which","is","a","sure","foundation,","a","foundation","whereon","if","men","build","they","cannot","fall."};
        public List<string> BOMList = new List<string>(BOM);
    }


    public class Display
    {
        public Display(List<string> scriptcopy,HiddenWords hw)
        {
            Console.WriteLine("Helaman 5:12");
            for (int i=0; i < scriptcopy.Count; i++)
                {
                    if(hw == null)
                    {
                        Console.Write(scriptcopy[i] + " ");
                    }
                    else if (hw.listIndex.Contains(i))
                    {
                        string hiddenword = new String('_', scriptcopy[i].Length);
                        Console.WriteLine(hiddenword);
                    }
                    else
                    {
                        Console.Write(scriptcopy[i] + " ");
                    }
                    
                }
        }
    }

    public class HiddenWords
    {
        public List<int> listIndex = new List<int>();
        public HiddenWords(){ }
        public void HideWords(int sizeoflist)
        {
            Random rnd = new Random();
            
            int currentindex;
            
            do 
            {
                    currentindex = rnd.Next(sizeoflist);
            } 
                while (listIndex.Contains(currentindex));

                listIndex.Add(currentindex);
            
        }
     }
}