using System.Text;

namespace CSharp_Course_Work_Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Dictionaries> dictionary = new List<Dictionaries>();
            bool start = false;
            int a = 0;
            int b = 0;
            int i = 0;
            int it = 0;
            if (!start)//Made by Egor
            {
                Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░██╗██████╗░░██████╗███████╗░██╗░░░░░░░██╗░█████╗░██████╗░██╗░░██╗ ▐▓█▀▀▀▀▀▀▀▀▀█▓▌░▄▄▄▄▄░
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔════╝██╔════╝░██║░░██╗░░██║██╔══██╗██╔══██╗██║░██╔╝ ▐▓█░░▀░░▀▄░░█▓▌░█▄▄▄█░
██║░░╚═╝██║░░██║██║░░░██║██████╔╝╚█████╗░█████╗░░░╚██╗████╗██╔╝██║░░██║██████╔╝█████═╝░ ▐▓█░░▄░░▄▀░░█▓▌░█▄▄▄█░
██║░░██╗██║░░██║██║░░░██║██╔══██╗░╚═══██╗██╔══╝░░░░████╔═████║░██║░░██║██╔══██╗██╔═██╗░ ▐▓█▄▄▄▄▄▄▄▄▄█▓▌░█████░
╚█████╔╝╚█████╔╝╚██████╔╝██║░░██║██████╔╝███████╗░░╚██╔╝░╚██╔╝░╚█████╔╝██║░░██║██║░╚██╗ ░░░░▄▄███▄▄░░░░░█████░
░╚════╝░░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝
");
                Console.WriteLine(@"
██████╗░██╗░█████╗░████████╗██╗░█████╗░███╗░░██╗░█████╗░██████╗░██╗░░░██╗ ░░░░░░░█▐▓▓░████▄▄▄█▀▄▓▓▓▌█
██╔══██╗██║██╔══██╗╚══██╔══╝██║██╔══██╗████╗░██║██╔══██╗██╔══██╗╚██╗░██╔╝ ░░░░░▄█▌▀▄▓▓▄▄▄▄▀▀▀▄▓▓▓▓▓▌█
██║░░██║██║██║░░╚═╝░░░██║░░░██║██║░░██║██╔██╗██║███████║██████╔╝░╚████╔╝░ ░░░▄█▀▀▄▓█▓▓▓▓▓▓▓▓▓▓▓▓▀░▓▌█
██║░░██║██║██║░░██╗░░░██║░░░██║██║░░██║██║╚████║██╔══██║██╔══██╗░░╚██╔╝░░ ░░█▀▄▓▓▓███▓▓▓███▓▓▓▄░░▄▓▐█
██████╔╝██║╚█████╔╝░░░██║░░░██║╚█████╔╝██║░╚███║██║░░██║██║░░██║░░░██║░░░ ░█▌▓▓▓▀▀▓▓▓▓███▓▓▓▓▓▓▓▄▀▓▓▐█
╚═════╝░╚═╝░╚════╝░░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░ ▐█▐██▐░▄▓▓▓▓▓▀▄░▀▓▓▓▓▓▓▓▓▓▌█▌
                                                                          █▌███▓▓▓▓▓▓▓▓▐░░▄▓▓███▓▓▓▄▀▐█
                                                                          █▐█▓▀░░▀▓▓▓▓▓▓▓▓▓██████▓▓▓▓▐█
                                                                          ▌▓▄▌▀░▀░▐▀█▄▓▓██████████▓▓▓▌█
                                                                          ▌▓▓▓▄▄▀▀▓▓▓▀▓▓▓▓▓▓▓▓█▓█▓█▓▓▌█
                                                                          █▐▓▓▓▓▓▓▄▄▄▓▓▓▓▓▓█▓█▓█▓█▓▓▓▐█

            
");

            }
            do//Made by Egor
            {
                Console.WriteLine(@"
1. Add new dictionary
2. Delete dictionary
3. Open dicitonary
4. Show All Dictionaries
0. Exit");
                b = Convert.ToInt32(Console.ReadLine());
                start = true;
                switch (b)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter name of dictionary: ");
                        string name = Console.ReadLine();
                        dictionary.Add(new Dictionaries(name));
                        name = null;
                        do
                        {
                            Console.WriteLine($"Dictionary: {dictionary[it].name}");
                            Console.WriteLine(@"
                                     1.Add word
                            
                                     2.print           
                            
                                     3.search          
                            
                                     4.change word     
                            
                                     5.change translate
                            
                                     6.delet word      
                            
                                     7.delet translete
                            
                                     8.save in file
                            
                                     9.upload from file
                            
                                     0.EXIT
                            
                            ");
                            Console.Write("Enter what to do: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            switch (a)
                            {
                                case 1:
                                    Console.Clear();
                                    dictionary[it].addWordAndTranslate();
                                    start = true;
                                    break;
                                case 2:
                                    Console.Clear();
                                    dictionary[it].print();
                                    start = true;
                                    break;
                                case 3:
                                    Console.Clear();
                                    dictionary[it].SearchTranslate();
                                    start = true;
                                    break;
                                case 4:
                                    Console.Clear();
                                    dictionary[it].changeWord();
                                    start = true;
                                    break;
                                case 5:
                                    Console.Clear();
                                    dictionary[it].changeTranslate();
                                    start = true;
                                    break;
                                case 6:
                                    Console.Clear();
                                    dictionary[it].DeleteWord();
                                    start = true;
                                    break;
                                case 7:
                                    Console.Clear();
                                    dictionary[it].deleteTrans();
                                    break;
                                case 8:
                                    Console.Clear();
                                    dictionary[it].SaveFile();
                                    start = true;
                                    break;
                                case 9:
                                    Console.Clear();
                                    dictionary[it].UploadFromFile();
                                    start = true;
                                    break;
                                case 0:
                                    a = -1;
                                    break;
                                default:
                                    break;

                            }
                        } while (a != -1);
                        Console.Clear();
                        it++;
                        break;
                    case 2:
                        Console.Clear();
                        foreach (Dictionaries d in dictionary.ToList())
                        {
                            Console.WriteLine($"Dictionary: {d.name}");
                        }
                        Console.Write("Enter name of dictionary to delete: ");
                        name = Console.ReadLine();
                        foreach (Dictionaries d in dictionary.ToList())
                        {
                            if (name == d.name)
                            {
                                dictionary.Remove(d);
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        foreach(Dictionaries d in dictionary.ToList())
                        {
                            Console.WriteLine($"Dictionary: {d.name}");
                        }
                        Console.Write("Enter name of dictionary to edit: ");
                        name = Console.ReadLine();
                        Console.Clear();
                        foreach (Dictionaries d in dictionary.ToList())
                        {
                            if (d.name == name)
                            {
                                do
                                {
                                    Console.WriteLine($"Dictionary: {dictionary[i].name}");
                                    Console.WriteLine(@"
                                     1.Add word
                            
                                     2.print           
                            
                                     3.search          
                            
                                     4.change word     
                            
                                     5.change translate
                            
                                     6.delet word      
                            
                                     7.delet translete
                            
                                     8.save in file
                            
                                     9.upload from file
                            
                                     0.EXIT
                            
                            ");

                                    a = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    switch (a)
                                    {
                                        case 1:
                                            Console.Clear();
                                            dictionary[i].addWordAndTranslate();
                                            start = true;
                                            break;
                                        case 2:
                                            Console.Clear();
                                            dictionary[i].print();
                                            start = true;
                                            break;
                                        case 3:
                                            Console.Clear();
                                            dictionary[i].SearchTranslate();
                                            start = true;
                                            break;
                                        case 4:
                                            Console.Clear();
                                            dictionary[i].changeWord();
                                            start = true;
                                            break;
                                        case 5:
                                            Console.Clear();
                                            dictionary[i].changeTranslate();
                                            start = true;
                                            break;
                                        case 6:
                                            Console.Clear();
                                            dictionary[i].DeleteWord();
                                            start = true;
                                            break;
                                        case 7:
                                            Console.Clear();
                                            dictionary[i].deleteTrans();
                                            break;
                                        case 8:
                                            Console.Clear();
                                            dictionary[i].SaveFile();
                                            start = true;
                                            break;
                                        case 9:
                                            Console.Clear();
                                            dictionary[i].UploadFromFile();
                                            start = true;
                                            break;
                                        case 0:
                                            a = -1;
                                            break;
                                        default:
                                            break;

                                    }
                                } while (a != -1);
                            }
                            i++;
                        }
                        it = 0;
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        foreach(Dictionaries d in dictionary.ToList())
                        {
                            Console.WriteLine($"Dictionary: {d.name}");
                        }
                        break;
                    case 0:
                        b = -1;
                        break;
                }
            } while (b != -1);
        }
    }
}