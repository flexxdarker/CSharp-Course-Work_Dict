namespace CSharp_Course_Work_Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ua-En";

            Dictionaries dictionary = new Dictionaries(name);
            int a = 0;
            do 
            { 
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
                    case 5:
                        dictionary.changeTranslate();
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