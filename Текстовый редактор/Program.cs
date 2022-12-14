using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.Xml.Serialization;
using Текстовый_редактор;

internal class program
{
    static void Main(string[] args)
    {
        Menu();
        int position = 0;
        do
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                
                position--;
                Console.Clear();
               
                Console.SetCursorPosition(1, position);
                Console.WriteLine("->");
                
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                position++;
                Console.Clear();
                Console.WriteLine("  1.TXT");
                Console.SetCursorPosition(1, position);
                Console.WriteLine("->");
            }
            else if (key.Key == ConsoleKey.Enter && position == 0)
            {
                TXT();
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                position++;
                Console.Clear();
                Console.WriteLine("  2.json");
                Console.SetCursorPosition(1, position);
                Console.WriteLine("->");
            }
            else if (key.Key == ConsoleKey.Enter && position == 2)
            {
                Json();
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                position++;
                Console.Clear();
                Console.WriteLine("  3.XML");
                Console.SetCursorPosition(1, position);
                Console.WriteLine("->");
            }
            else if (key.Key == ConsoleKey.Enter && position == 1)
            {
                XML();
            }
            


            else if (key.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
            
                Console.SetCursorPosition(1, position);
                Console.WriteLine("->");
            }
        }


        while (true);

        static void TXT()
        {
            Console.WriteLine("Введите текст, который хотите сохранить");
            string read = Console.ReadLine();
            Human Andrew = new Human();
            Andrew.Name = "Андрей";
            List<Human> humans = new List<Human>();
            humans.Add(Andrew);
            string text = File.ReadAllText("C:\\Users\\lexre\\Desktop\\у меня друг даун.txt");
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\у меня друг даун.txt", "\n");
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\у меня друг даун.txt", Andrew.Name);
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\у меня друг даун.txt", "\n");
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\у меня друг даун.txt", read);
            Console.SetCursorPosition(5, 5);
            Console.WriteLine(text);
            Console.ReadKey();
            Console.Clear();
        }

        static void XML()
        {
            Console.WriteLine("Введите текст, который хотите сохранить");
            string read = Console.ReadLine();
            Human Andrew = new Human();
            Andrew.Name = "Андрей";

            List<Human> humans = new List<Human>();
            humans.Add(Andrew);

            System.Xml.Serialization.XmlSerializer XML = new System.Xml.Serialization.XmlSerializer(typeof(Human));
            using (FileStream fs = new FileStream("C:\\Users\\lexre\\Desktop\\файл.XML", FileMode.OpenOrCreate))
            {
                XML.Serialize(fs, Andrew);
                XML.Serialize(fs, read);
            }

            Human human;

            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(Human));
            using (FileStream fs = new FileStream("C:\\Users\\lexre\\Desktop\\файл.XML", FileMode.Open))
            {
                human = (Human)XML.Deserialize(fs);
            }
        }
        static void Json()
        {
            Console.WriteLine("Введите текст, который хотите сохранить");
            string read = Console.ReadLine();
            Human Andrew = new Human();
            Andrew.Name = "Андрей";
            Andrew.Age = 18;
            Andrew.MyFavouriteGroup = new string[] { "Black sabbath", "Bathory" };
            List<Human> humans = new List<Human>();
            humans.Add(Andrew);
            string json = JsonConvert.SerializeObject(humans);
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\Myfabouritegroup.Json.txt", "\n"); 
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\Myfabouritegroup.Json.txt", json);
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\Myfabouritegroup.Json.txt", "\n");
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\Myfabouritegroup.Json.txt", read);
            string text = File.ReadAllText("C:\\Users\\lexre\\Desktop\\Myfabouritegroup.Json.txt");
            List<Human> result = JsonConvert.DeserializeObject<List<Human>>(text);
            Console.SetCursorPosition(5, 5);
            Console.WriteLine(text);
            Console.ReadKey();
            Console.Clear();
        }
        static void Menu()
        {
            Console.WriteLine("  1.TXT");
            {

            }
            Console.WriteLine("  2.Json");
            {


            }
            Console.WriteLine("  3.XML");
            {

            }












        }



























    }
}

 