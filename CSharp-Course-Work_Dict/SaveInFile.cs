using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Json;

namespace CSharp_Course_Work_Dict
{
    internal class SaveInFile
    {
        public void SaveFile(Dictionaries dictionaries)
        {
            Console.Write("Enter name of file: ");
            string tmpfileName = Console.ReadLine();
            string fileName = tmpfileName + ".json";
            try
            {
                var options = new JsonSerializerOptions 
                { 
                    WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All), 
                };
                string json = JsonSerializer.Serialize(options);
                File.WriteAllText(fileName, json);
                Console.WriteLine("Saving into file completed!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UploadFromFile(Dictionaries dictionaries)
        {
            Console.Write("Enter name of file to upload: ");
            string tmpfileName = Console.ReadLine();
            string fileName = tmpfileName + ".json";
            string desDitc = File.ReadAllText(fileName);
            dictionaries = JsonSerializer.Deserialize<Dictionaries>(desDitc);
        }
    }
}
