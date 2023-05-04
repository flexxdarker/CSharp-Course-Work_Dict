﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharp_Course_Work_Dict
{
    internal class Dictionaries
    {
        public string name { get; set; }
        private Dictionary<string, List<string>> dictionaries { get; set; }
        public Dictionaries(string name, string word, List<string> translate)
        {
            this.name = name;
            dictionaries = new Dictionary<string, List<string>>();
            dictionaries.Add(word, translate);
        }
        public Dictionaries(string name)
        {
            this.name = name;
            dictionaries = new Dictionary<string, List<string>>();
        }
        public void print()
        {
            Console.Clear();
            Console.WriteLine("=================");
            
            foreach (KeyValuePair<string, List<string>> tmp in dictionaries)
            {
                Console.WriteLine($@"Word {tmp.Key}      
    ||
   _||_
   \  /
    \/");
                foreach (var translate in tmp.Value)
                {
                    Console.WriteLine($"Translate {translate}");
                }
            }
            Console.WriteLine("================");
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
            Console.Clear();
            print();
            Console.Write("Enter word to change: ");
            string changeword = Console.ReadLine();
            List<string> tmptransalte = new List<string>();
            if (dictionaries.Keys.Contains(changeword))
            {
                foreach (var trans in dictionaries[changeword])
                {
                    tmptransalte.Add(trans.ToString());
                }

                dictionaries.Remove(changeword);
                Console.Write("Enter new Word: ");
                string tmpWord = Console.ReadLine();
                dictionaries.Add(tmpWord, tmptransalte);
                print();
            }
            else
            {
                Console.WriteLine($"Don't contain: {changeword}");
            }

        }
        public void changeTranslate()
        {
            Console.Clear();
            print();
            Console.Write("Enter word to change: ");
            string tmpword = Console.ReadLine();
            if (dictionaries.Keys.Contains(tmpword))
            {
                dictionaries.Remove(tmpword);
                List<string> tmpTranslate = new List<string>();
                Console.Write("Enter new translate: ");
                string tmp = Console.ReadLine();
                Console.Write("Do you want to add another translate?(1.Yes 2.No): ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a != 2)
                {
                    Console.Write($"Enter a translate to {tmpword}:   ");
                    tmp = Console.ReadLine();
                    tmpTranslate.Add(tmp);
                }
                dictionaries.Add(tmpword, tmpTranslate);
                print();

            }
        }

        public void DeleteWord()
        {
            Console.Clear();
            print();
            Console.Write("Enter word to delete");
            string deleteword = Console.ReadLine();
            if (dictionaries.Keys.Contains(deleteword))
            {
                foreach (var word in dictionaries[deleteword])
                {
                    dictionaries.Remove(deleteword);
                }
            }
            else { Console.WriteLine($"Dictionary don't contains: {deleteword}"); }

        }
        public void deleteTrans()
        {
            Console.WriteLine("Enter word to delete translete");
            string word = Console.ReadLine();
            if (dictionaries.Keys.Contains(word))
            {
                Console.WriteLine("Enter translate to delete: ");
                string deletetrans = Console.ReadLine();
                if (dictionaries[word].Contains(deletetrans))
                {
                    dictionaries[word].Remove(deletetrans);
                }
                else
                { Console.WriteLine($"Dictionary don't contains: {deletetrans}"); }
            }
            else
            { Console.WriteLine($"No such word as: {word}"); }
        }
        public void SearchTranslate()
        {
            Console.Clear();
            print();
            Console.WriteLine("Enter word to search: ");
            string tmp = Console.ReadLine();
            var result = dictionaries.Where(x => tmp.Contains(x.Key)).SelectMany(x => x.Value).ToList();
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

        }
        public void SaveFile()
        {
            Console.Clear();
            Console.Write("Enter name of file: ");
            string tmpfileName = Console.ReadLine();
            string fileName = tmpfileName + ".json";
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All),
                };
                string json = JsonSerializer.Serialize(dictionaries, options);
                File.WriteAllText(fileName, json);
                Console.WriteLine("Saving into file completed!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UploadFromFile()
        {
            Console.Clear();
            try
            {
                Console.Write("Enter name of file: ");
                string tmpFileName = Console.ReadLine();
                string FileName = tmpFileName + ".json";
                string deserializedList = File.ReadAllText(FileName);
                Dictionary<string, List<string>> tmp = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(deserializedList);
                dictionaries = tmp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

    }
}
