List<Person03> PersonList = new List<Person03>();
string[] RandomName = new string[1000];

Random r = new Random();

var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
var Chararr = new char[5];
for (int j = 0; j < 1000; j++)
{
         for (int i = 0; i < Chararr.Length; i++)
         {
         Chararr[i] = characters[r.Next(characters.Length)];

         }
     RandomName[j] = new String(Chararr);
}

string[] city = new string[5] {"tehran", "kerman", "yazd", "karaj","rasht" };
//var RandomCity = city[r.Next(4)];

for (int i = 0; i < 1000; i++)
{
    Person03 person = new Person03(i+1, RandomName[i], r.Next(2, 40),r.Next(1990,2020) ,r.Next(1111111111, 2147483647), city[r.Next(4)]);
    PersonList.Add(person);
}

foreach (var item in PersonList)
{
Console.WriteLine($"{item.id}-{item.Name}-{item.Age}-{item.Birthday}-{item.CodeMeli}-{item.Aderess}");
}

Console.WriteLine("Press 1 to print Age>20");
Console.WriteLine("Press 2 to Birthday>1990");
Console.WriteLine("Press 3 to Birthday is equal");
Console.WriteLine("Press 4 to sort by ID and Remove person 4");
Console.WriteLine("Press 5 to sort by ID and Remove person 50 To 80");
Console.WriteLine("Press 6 to Print Person that have Max Birthday");
Console.WriteLine("Press 7 to is there repeted codemeli?");
Console.WriteLine("Press 8 to print person that contain tehran");
Console.WriteLine("Press 9 to print person that contain tehran");
Console.WriteLine("Press 10 to print person that contain tehran");
Console.WriteLine("Press 11 to age top 25");
var k = Console.ReadLine();
switch  (k)

{
    case "1":
        Console.Clear();
        Console.WriteLine("**************List of Age>20");
        {
            List<Person03> list1 = PersonList.Where(p => p.Age > 20).ToList();
            print(list1);
        }
        break;
    case "2":
        Console.Clear();
        Console.WriteLine("*************Press 2 to Birthday>1990");
        {
            List<Person03> list1 = PersonList.Where(p => p.Birthday > 1990).ToList();
            print(list1);
        }
        break;
    case "3":
        {
            Console.Clear();
                var Birth = PersonList.GroupBy(p => p.Birthday);

                foreach (var item in Birth)
                {
                    Console.WriteLine($"--------------------------{item.Key}--------------------------");
                    foreach (var item1 in item)
                    {
                        Console.WriteLine($"{item1.id}-{item1.Name}-{item1.Age}-{item1.CodeMeli}-{item1.Aderess}");
                    }
                }

                  
            break;

        }
    case "4":
        {
            Console.Clear();
            List<Person03> list1 = PersonList.OrderBy(p => p.id).ToList();
            list1.RemoveAt(3);
            Console.WriteLine("Remove person 4 is complate");
        }
        break;

    case "5":
        {
            Console.Clear();
            List<Person03> list1 = PersonList.OrderBy(p => p.id).ToList();
            list1.RemoveRange(50, 80);
            print(list1);
            Console.WriteLine("Remove person 50 To 80 is complate");
        }
        break;

    case "6":
        {
            Console.Clear();
            var MaxBirth = PersonList.Max(p=>p.Birthday);
            List<Person03> list1 = PersonList.Where(p => p.Birthday==MaxBirth).ToList();
            Console.WriteLine($"Max Birth is----------------{MaxBirth}--------------------------");
            print(list1);
        }
        break;
    case "7":
        {
            Console.Clear();
            var code = PersonList.GroupBy(p => p.CodeMeli).ToArray();
            Console.Write(code.Length);
            if (code.Length == 1000) Console.Write("ther is not repeted codemeli");
            else Console.Write("ther is repeted codemeli");
        }

        break;

    case "8":
        {
            Console.Clear();
            List<Person03> list1 = PersonList.Where(p => p.Aderess.Contains("tehran")).ToList();           
            print(list1);
            
        }

        break;

    case "9":
        {
            Console.Clear();
            var t = PersonList.Where(p => p.Aderess.Contains("tehran")).GroupBy(s=>s.Name);
            foreach (var item in t)
            {
                if (item.Count() > 1)
                {
                    Console.WriteLine($"Group is --------{item.Key}");
                    foreach (var item1 in item)
                    {
                        Console.WriteLine($"{item1.id}-{item1.Name}-{item1.Age}-{item1.CodeMeli}-{item1.Aderess}");
                    }
                }
                
                
            }

        }

        break;
    case "10":
        {
            Console.Clear();
            var s = PersonList.Select(p => p.CodeMeli).ToArray();
            string[] result = s.Select(x => x.ToString()).ToArray();
            var s1 = result.Where(p => p.Contains("123")).ToList();
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
        }
        break;
    case "11":
        {
            Console.Clear();
            Console.WriteLine("list of person top age 25");
            var list  = PersonList.Where(p => p.Age > 25).Select(s =>new{s.CodeMeli,s.Aderess}).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.CodeMeli}--{item.Aderess}");
            }
            
        }
        break;
}





  void print(List<Person03> x)
{
    foreach (var item in x)
    {
        Console.WriteLine($"{item.id}-{item.Name}-{item.Age}-{item.CodeMeli}-{item.Aderess}");
    }
}
