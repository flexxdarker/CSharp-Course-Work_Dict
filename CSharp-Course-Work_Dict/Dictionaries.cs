using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Work_Dict
{
    internal class Dictionaries
    {
        private string name { get; set; }
        Dictionary<string,List<string>> dictionaries { get; set;}
        Dictionaries(string name, string word, List<string> translate) 
        {
            this.name = name;
            dictionaries.Add(word, translate);
        }
        public void print()
        {
            Console.Clear();
            Console.WriteLine($"Name of dictionary: {name}");
            foreach (var translate in dictionaries.Values)
            {
                foreach(var word in dictionaries.Keys)
                {
                    Console.WriteLine($"Word {word} -> Translate {translate}");
                }
            }
        }
        public void addWordAndTranslate(string word, List<string> translate)
        {
            Console.Clear();
            dictionaries.Add(word, translate);
            print();
        }
        public void changeWord(string changeword)
        {
            List<string> tmptransalte = new List<string>();
            foreach(var trans in dictionaries.Values)
            {
                tmptransalte.Add(trans.ToString());
            }
            if(dictionaries.Keys.Contains(changeword))
            {
                dictionaries.Remove(changeword);
                Console.Write("Enter new Word: ");
                string tmpWord = Console.ReadLine();
                dictionaries.Add(tmpWord, tmptransalte);
            }
        }
        public void changeTranslate(List<string> translate)
        {
            
        }
    }
}
