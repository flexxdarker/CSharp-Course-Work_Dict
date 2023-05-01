using System;
using System.Collections;
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
        private Dictionary<string,List<string>> dictionaries { get; set;}
        public Dictionaries(string name, string word, List<string> translate) 
        {
            this.name = name;
            dictionaries = new Dictionary<string,List<string>>();
            dictionaries.Add(word, translate);
        }
        public Dictionaries(string name) 
        {
            this.name = name;
            dictionaries = new Dictionary<string,List<string>>();
        }
        public void print()
        {
            Console.Clear();
            Console.WriteLine($"Name of dictionary: {name}");
            foreach (KeyValuePair<string, List<string>> tmp in dictionaries)
            {
                Console.Write($"Word {tmp.Key} -> ");
                foreach (var translate in tmp.Value)
                {
                    Console.WriteLine($"Translate {translate}");
                }
            }
        }
        public void addWordAndTranslate()
        {
            Console.Clear();
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            if (dictionaries.Keys.Contains(word))
            {
                Console.Write("Enter translate of word: ");
                string value = Console.ReadLine();
                dictionaries[word].Add(value);
            }
            else
            {
                Console.Write("Enter translate of word: ");
                string value = Console.ReadLine();
                List<string> translation = new List<string>();
                translation.Add(value);
                dictionaries.Add(word, translation);
            }
        }
        public void changeWord()
        {
            print();
            Console.Write("Enter word to change");
            string changeword = Console.ReadLine();
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
        public void SearchTranslate()
        {
            Console.WriteLine("Enter word to search: ");
            string tmp = Console.ReadLine();
            var result = dictionaries.Where(x => tmp.Contains(x.Key)).SelectMany(x => x.Value).ToList();
            foreach(var res in result)
            {
                Console.WriteLine(res);
            }
        }
        
    }
}
