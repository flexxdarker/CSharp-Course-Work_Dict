namespace CSharp_Course_Work_Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ua-En";

            //List<Dictionaries> dictionary;
            int a = 0;
            //do
            //{
            //    Console.WriteLine("1. add word");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    switch (a)
            //    {
            //        case 1:
            //            dictionary = new List<Dictionaries>();
            //            dictionary.Add(new Dictionaries(name));
            //            dictionary[0].addWordAndTranslate();
            //            dictionary[0].print();
            //            Console.WriteLine(dictionary[0].name);
            //            break;
            //        default:
            //            break;
            //    }
            //} while (a != -1);
            Dictionaries dictionary = new Dictionaries(name);
            do
            {

                Console.WriteLine(@"1.Add word
2.print
3.search
4.change
5.delete word
0.exit");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        dictionary.addWordAndTranslate();
                        break;
                    case 2:
                        dictionary.print();
                        break;
                    case 3:
                        dictionary.SearchTranslate();
                        break;
                    case 4:
                        dictionary.changeWord();
                        break;
                    case 5:dictionary.DeleteWord();
                        break;
                    case 0:
                        a = -1;
                        break;
                    default:
                        break;

                }
            } while (a != -1);

        }
    }
}